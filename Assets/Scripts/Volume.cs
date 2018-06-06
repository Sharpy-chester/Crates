using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour {

    //At the moment all this does it change the sprite image as there are no sounds in the game yet

    public Sprite volumeOff;
    public Sprite volumeOn;
    public bool volume = false;


    void Start()
    {
        OnMouseDown();
    }

    void OnMouseDown()
    {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
        if (volume == true)
        {
            sr.sprite = (volumeOff);
            volume = false;
        }
        else
        {
            sr.sprite = (volumeOn);
            volume = true;
        }


    }
}
