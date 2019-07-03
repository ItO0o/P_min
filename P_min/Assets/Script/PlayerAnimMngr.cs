using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimMngr : MonoBehaviour {
    Vector3 tmp;
    Animator anm;
    public GameObject neck;
    Vector3 prePos;
    bool flag  = false;
    // Use this for initialization
    void Start() {
        anm = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        flag = false;
        Vector3 vec = (this.transform.position - tmp).normalized;
        this.transform.LookAt(new Vector3(this.transform.position.x + vec.x,this.transform.position.y, this.transform.position.z + vec.z));
        tmp = this.transform.position;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            anm.SetFloat("Speed", 1);
        } else {
            anm.SetFloat("Speed", 0);
        }
        if (this.GetComponent<PlayerMove>().getGndState() && Input.GetKeyDown(KeyCode.Space)) {
            flag = true;
            anm.SetBool("Jump", true);
        }
    }
    private void LateUpdate() {
        if (anm.GetBool("Jump") && this.GetComponent<PlayerMove>().getGndState() && flag == false) {
            anm.SetBool("Jump", false);
        }
        //Vector3 toCamera = GameObject.Find("Main Camera").transform.position - this.transform.position;
        //float angle = (Mathf.Atan2(toCamera.z, toCamera.x) * Mathf.Rad2Deg);
        ////Debug.Log(this.transform.rotation);
        //angle = angle - (this.transform.eulerAngles.y - 180f);
        //Debug.Log(angle +","+ (this.transform.eulerAngles.y - 180f));
        //if (angle > 45 && angle < 135) {
        //    //neck.transform.rotation = Quaternion.identity;
        //    //neck.transform.Rotate(angle, 0f, 0f);
        //} else {
        //    //neck.transform.localRotation = new Quaternion(0,0,0,0);
        //}
    }
}
