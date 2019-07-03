using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikminMove : MonoBehaviour {
    P_minMode preMode = new P_minMode();
    GameObject player;
    Vector3 moveVec;
    public float speed;
    P_minMode mode = new P_minMode();
    Vector3 myPos;
    int i;
    // Use this for initialization
    void Start() {
        player = GameObject.Find("Player");
        this.mode = this.GetComponent<P_minMode>();
    }

    // Update is called once per frame
    void Update() {
        if (this.mode.p_mode == P_minMode.mode.follow) {
            this.moveVec = player.transform.position - this.transform.position;
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.moveVec.normalized.x * this.speed, this.GetComponent<Rigidbody>().velocity.y, this.moveVec.normalized.z * this.speed);
        } else if (this.mode.p_mode == P_minMode.mode.alignment) {
            if (this.preMode.p_mode != P_minMode.mode.alignment) {
                for (this.i = 0; this.i < 100; this.i++) {
                    if (player.GetComponent<AlignmentPosition>().inPosition[this.i] == false) {
                        player.GetComponent<AlignmentPosition>().inPosition[this.i] = true;
                        break;
                    }
                }
            }
            this.myPos = player.GetComponent<AlignmentPosition>().posObj[this.i].transform.position;
            //Debug.Log(this.transform.name + ","+ myPos);
            this.GetComponent<Rigidbody>().velocity = (this.myPos - this.transform.position).normalized * this.speed;
        }
        if (this.preMode.p_mode == P_minMode.mode.alignment && this.mode.p_mode != P_minMode.mode.alignment) {
            player.GetComponent<AlignmentPosition>().inPosition[this.i] = false;
        }
        if (this.mode.p_mode == P_minMode.mode.avoidance)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-1, 1), this.GetComponent<Rigidbody>().velocity.y, Random.Range(-1, 1));
        }
        this.preMode.p_mode = this.mode.p_mode;
    }
}
