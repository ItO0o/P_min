using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCont : MonoBehaviour {
    GameObject alignment;
    // Use this for initialization
    void Start () {
        alignment = GameObject.Find("Alignment");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit_info = new RaycastHit();
            float max_distance = 15f;

            if(Physics.Raycast(ray, out hit_info, max_distance)) {
                //if (!hit_info.transform.name.Equals("Alignment")) {
                    alignment.transform.position = hit_info.point;
                //}
            }
        }
        
    }
}
