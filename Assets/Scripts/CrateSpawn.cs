using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawn : MonoBehaviour {


    public float time;
    public float spawnTime;
    public GameObject crate;
    public List<GameObject> spawnPoints = new List<GameObject>();
    public GameObject player;
    public GameObject actualPlayer;
    public Transform playerlocation;
    public List<GameObject> lives = new List<GameObject>();
    //public GameObject[] lives;
    public float hitCooldown = 1f;
    public int lifes = 3;

    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("RaySpawn");
        //lives = GameObject.FindGameObjectsWithTag("Lives");
        actualPlayer = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		Spawns ();
        Lives ();
	}

    

	void Spawns(){
        var spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
        time = time + Time.deltaTime;
        if (time >= spawnTime)
        {
            Instantiate(crate, spawnPoint.transform.position, transform.rotation);
            time = 0f;
            //spawnTime = spawnTime - 0.1f;
        }

    }
    void Lives()
    {
        if (lifes > 0)
        {
            playerlocation = player.GetComponent <Transform> ();
        
            RaycastHit2D ray = Physics2D.Raycast(playerlocation.position, Vector2.up, 0.4f); //Collider would have been a lot easier and probably more optimised
            Debug.DrawRay(playerlocation.position, Vector2.up, Color.green, Time.deltaTime);
            if (hitCooldown < 2)
            {
                hitCooldown = hitCooldown + Time.deltaTime;
            }
            if (ray.collider != null)
            {
                if (ray.collider.name == "CratePink 1(Clone)")
                {
                    if (hitCooldown > 1.99f)
                    {
                        Debug.Log("working1");
                        var curLife = lives[lifes - 1];
                        
                        lives.RemoveAt(lifes - 1);
                        Destroy(curLife);
                        //Destroy(GameObject.FindGameObjectWithTag("Lives"));
                        hitCooldown = 0f;
                        lifes = lifes - 1;
                    }
                
                }
            }
            if (lifes == 0)
            {
                Destroy(actualPlayer);
            }
        }
        else
        {
            //end game stuff here
        }
        
        
    }
}