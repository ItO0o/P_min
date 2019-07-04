using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_minMode : MonoBehaviour {

    public enum mode{
        follow,
        attack,
        recovery,
        alignment,
        avoidance,
        non
    }

    public mode p_mode;

    // Use this for initialization
    void Awake () {
        p_mode = mode.follow;
    }
	
	// Update is called once per frame
	void Update () {
    }
}
