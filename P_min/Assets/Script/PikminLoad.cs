using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikminLoad : MonoBehaviour {
    GameObject onion;
    // Use this for initialization
    void Start() {
        onion = GameObject.Find("Onion");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Z)) {
            GameObject obj = (GameObject)Resources.Load("Pikmin");
            GameObject instObj = Instantiate(obj);
            instObj.transform.position = onion.transform.position + new Vector3(0, 5, 0);
            instObj.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-3, 3), 6, Random.Range(-3, 3));
        }
    }
}
