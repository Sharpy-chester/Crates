using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLines : MonoBehaviour {

    //This manages the end of level stuff. Needs a lot of updating as it only destroys the player at the moment and does nothing else.

    public GameObject player;
    public GameObject FinishLeft;
    public GameObject FinishRight;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "CharacterRobotBoy")
        {
            //Put end of level stuff here
            GameObject.Destroy(player);
        }
        
    }
}
