using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

    public Object level1;

    void OnMouseDown()
    {
        SceneManager.LoadScene("MainScene");
    }
}
