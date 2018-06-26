using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check : MonoBehaviour
{

    //This isn't relevent to the Crates project but I was testing a cryptocurrency's API. With this you can input a Verge public address and see the balance on the address by using the Verge iquidus explorer API

    public InputField address;
    public Button checkBTN;
    public Text amount;
    //If you want to create a scene with this, simply create an input field, button, and text object and plug them into the corrosponding variables in the inspector

    void Start()
    {
        checkBTN.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        amount.text = ("Balance: Loading...");
        string verge = address.text; //The variable Verge is what the user inputs into the text box (input field). This will be a Verge address.
        Debug.Log(verge);
        string url = "https://verge-blockchain.info/ext/getbalance/" + verge; //D6a8ayKEpdj71qh6b1iLxYEXxMX9KfbggD - Example address
        WWW website = new WWW(url);
        StartCoroutine(WaitForRequest(website));
    }

    IEnumerator WaitForRequest(WWW website)
    {
        yield return website;
        Debug.Log("Working: " + website.text);
        amount.text = "Balance: " + website.text;
    }
}
