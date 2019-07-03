using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

    GameObject player;
    GameObject text;


	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        text = GameObject.Find("Text");
        text.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //if (条件) {
        //    処理
        //}
        //player.GetComponent<Rigidbody>().AddForce(new Vector3(1,0,0));
        if (Input.GetKey(KeyCode.A)) {
            player.transform.position = player.transform.position + new Vector3(-0.1f, 0, 0);
        }   
        if (Input.GetKey(KeyCode.S)) {
            player.transform.position = player.transform.position + new Vector3(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.D)) {
            player.transform.position = player.transform.position + new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)) {
            player.transform.position = player.transform.position + new Vector3(0, 0, 0.1f);
        }
    }

    private void OnCollisionStay(Collision other) {
        if (Input.GetKey(KeyCode.Space)) {
            player.transform.position = player.transform.position + new Vector3(0, 1, 0);
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name.Equals("Enemy")) {
            //表示
            text.SetActive(true);
        }
    }
}
