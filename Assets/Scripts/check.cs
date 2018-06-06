﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check : MonoBehaviour
{

    public InputField address;
    public Button checkBTN;
    public Text amount;

    void Start()
    {
        checkBTN.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        amount.text = ("Balance: Loading...");
        string verge = address.text;
        Debug.Log(verge);
        string url = "https://verge-blockchain.info/ext/getbalance/" + verge; //D6a8ayKEpdj71qh6b1iLxYEXxMX9KfbggD
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