using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikminLoad : MonoBehaviour {
    GameObject onion;
    GameObject tmpP_min;
    int cnt = 0;
    // Use this for initialization
    void Start() {
        onion = GameObject.Find("Onion");
        tmpP_min = GameObject.Find("Pikmins");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Z)) {
            GameObject obj = (GameObject)Resources.Load("P-min");
            GameObject instObj = Instantiate(obj);
            instObj.transform.position = onion.transform.position + new Vector3(0, 5, 0);
            instObj.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-3, 3), 6, Random.Range(-3, 3));
            instObj.transform.parent = tmpP_min.transform;
            instObj.name = "P_" + cnt;
            cnt++;
        }
    }
}
