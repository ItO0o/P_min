using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject enemy = Resources.Load<GameObject>("Enemy");
        Instantiate(enemy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
