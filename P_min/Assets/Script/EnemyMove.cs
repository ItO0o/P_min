using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other) {
        if (other.transform.name.Equals("Player_Zone")) {
            this.transform.LookAt(new Vector3(player.transform.position.x,this.transform.position.y,player.transform.position.z));
            Vector3 toPlayer =  (player.transform.position - this.transform.position).normalized * this.GetComponent<CreateEnemy>().GetEnemy().speed;
            this.GetComponent<Rigidbody>().velocity = new Vector3(toPlayer.x, this.GetComponent<Rigidbody>().velocity.y,toPlayer.z);
        }
    }
}
