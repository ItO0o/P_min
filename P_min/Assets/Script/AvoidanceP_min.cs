using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidanceP_min : MonoBehaviour
{
    P_minMode.mode tmp;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag.Equals("P_min"))
        {
            tmp = this.GetComponent<P_minMode>().p_mode;
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.transform.tag.Equals("P_min"))
        {
            this.transform.GetComponent<P_minMode>().p_mode = P_minMode.mode.avoidance;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.transform.tag.Equals("P_min"))
        {
            this.transform.GetComponent<P_minMode>().p_mode = tmp;
        }
    }
}
