using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_minAnime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.GetComponent<Rigidbody>().velocity.magnitude > 0.1f) {
            this.GetComponent<Animator>().SetFloat("Speed",this.GetComponent<Rigidbody>().velocity.magnitude / 10);
        } else {
            this.GetComponent<Animator>().SetFloat("Speed", 0);
        }
        this.transform.LookAt(new Vector3(this.transform.position.x + this.GetComponent<Rigidbody>().velocity.normalized.x, this.transform.position.y, this.transform.position.z + this.GetComponent<Rigidbody>().velocity.normalized.z));
    }
}
