﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

    //Should create a single script called SceneManager instead of having a script for each button.

    void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
