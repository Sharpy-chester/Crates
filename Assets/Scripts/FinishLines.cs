using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLines : MonoBehaviour {

    public GameObject player;
    public GameObject FinishLeft;
    public GameObject FinishRight;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "CharacterRobotBoy")
        {
            GameObject.Destroy(player);
        }
        
    }
}
