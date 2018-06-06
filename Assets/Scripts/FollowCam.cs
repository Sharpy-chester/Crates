using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowCam : MonoBehaviour {

    public GameObject player;
    private Transform startPos;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        startPos = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {

        Follow();
	}


    void Follow()
    {
        //if (player.transform.position.x <= -2.5f){
            this.gameObject.transform.position = player.transform.position;
            Vector3 pos = transform.position;
            pos.z -= 10;
            transform.position = pos;
        //}
        //else if (player.transform.position.x >= 2.5f)
        //{
        //    this.gameObject.transform.position = player.transform.position.normalized;
        //    Vector3 pos = transform.position;
        //    pos.z -= 10;
        //    transform.position = pos;
        //}
        //else
        //{
        //    this.transform.position = startPos.position;
        //}
    }
}
