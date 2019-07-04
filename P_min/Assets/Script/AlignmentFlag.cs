using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignmentFlag : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(this.transform.name+","+this.transform.GetComponent<P_minMode>().p_mode);
	}
    private void OnTriggerStay(Collider other) {
        if (other.transform.name.Equals("Alignment_Zone") && this.GetComponent<P_minMode>().p_mode == P_minMode.mode.follow) {
            this.transform.GetComponent<P_minMode>().p_mode = P_minMode.mode.alignment;
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.transform.name.Equals("Alignment_Zone") && this.GetComponent<P_minMode>().p_mode != P_minMode.mode.attack) {
            this.transform.GetComponent<P_minMode>().p_mode = P_minMode.mode.non;
        }
    }
}
