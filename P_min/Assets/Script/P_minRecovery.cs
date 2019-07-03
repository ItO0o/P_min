using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_minRecovery : MonoBehaviour {
    P_minMode mode = new P_minMode();
    GameObject enemy;
    // Use this for initialization
    void Start () {
        this.mode = this.transform.parent.GetComponent<P_minMode>();
    }
	
	// Update is called once per frame
	void Update () {
		if(this.mode.p_mode == P_minMode.mode.recovery) {
            Vector3 toEnemy = (enemy.transform.position - this.transform.parent.gameObject.transform.position).normalized;
            this.transform.parent.gameObject.GetComponent<Rigidbody>().velocity = toEnemy * 2;
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.transform.tag.Equals("Enemy") && this.mode.p_mode == P_minMode.mode.follow) {
            this.enemy = other.gameObject;
            if (this.enemy.GetComponent<CreateEnemy>().dead == true) {
                this.mode.p_mode = P_minMode.mode.recovery;

            }
        }
    }
}
