using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowCam : MonoBehaviour {

    //This is only enabled on level 2 and keeps the camera centered on the player.

    public GameObject player;
    private Transform startPos;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        startPos = this.gameObject.transform;
	}
	
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
