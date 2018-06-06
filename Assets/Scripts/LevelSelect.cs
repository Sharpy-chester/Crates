using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
