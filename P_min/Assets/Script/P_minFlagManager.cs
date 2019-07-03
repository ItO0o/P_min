using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_minFlagManager : MonoBehaviour
{
    P_minMode.mode tmp;
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.name.Equals("Alignment_Zone"))
        {
            this.transform.GetComponent<P_minMode>().p_mode = P_minMode.mode.alignment;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name.Equals("Alignment_Zone"))
        {
            this.transform.GetComponent<P_minMode>().p_mode = P_minMode.mode.follow;
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.transform.tag.Equals("P_min"))
        {
            tmp = this.GetComponent<P_minMode>().p_mode;
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
