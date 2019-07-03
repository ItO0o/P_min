using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    Transform myCamera;
    public float speed;
    Vector3 move;
    bool gnd = false;
    public float jumpPower;

    // Use this for initialization
    void Start() {
        myCamera = GameObject.Find("Main Camera").transform;
        move = new Vector3(0, this.GetComponent<Rigidbody>().velocity.y, 0);
    }

    // Update is called once per frame
    void Update() {
        Vector3 velocity = this.GetComponent<Rigidbody>().velocity;

        if (Input.GetKey(KeyCode.Space)) {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpPower, 0));
        }
        if (gnd == false) {
            return;
        }
        if (Input.GetKey(KeyCode.W)) {
            move += new Vector3(myCamera.forward.x, velocity.y, myCamera.forward.z);
        }
        if (Input.GetKey(KeyCode.D)) {
            move += new Vector3(myCamera.right.x, velocity.y, myCamera.right.z);
        }
        if (Input.GetKey(KeyCode.A)) {
            move += new Vector3(-myCamera.right.x, velocity.y, -myCamera.right.z);
        }
        if (Input.GetKey(KeyCode.S)) {
            move += new Vector3(-myCamera.forward.x, velocity.y, -myCamera.forward.z);
        }

        Vector2 vec = new Vector2(move.x, move.z);
        Vector2 tmp = vec.normalized;
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S)) {
            this.GetComponent<Rigidbody>().velocity = new Vector3(tmp.x * speed, velocity.y, tmp.y * speed);
            move = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            this.GetComponent<Rigidbody>().velocity = new Vector3(velocity.x, jumpPower * 2, velocity.z);
        }
    }

    public bool getGndState() {
        return this.gnd;
    }

    private void OnCollisionStay(Collision collision) {
        if (collision.transform.tag.Equals("Floor")) {
            gnd = true;
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.transform.tag.Equals("Floor")) {
            gnd = false;
        }
    }
}
