using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignmentP_min : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag.Equals("P_min")) {
            other.gameObject.GetComponent<P_minMode>().p_mode = P_minMode.mode.follow;
        }
    }
}
