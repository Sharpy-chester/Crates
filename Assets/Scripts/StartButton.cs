using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

    //Should create a single script called SceneManager instead of having a script for each button.

    public Object level1;

    void OnMouseDown()
    {
        SceneManager.LoadScene("MainScene");
    }
}
