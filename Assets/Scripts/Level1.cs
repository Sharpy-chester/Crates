﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("MainScene");
    }
}