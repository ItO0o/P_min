using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikminMove : MonoBehaviour {
    P_minMode preMode = new P_minMode();
    Vector3 moveVec;
    public float speed;
    P_minMode mode = new P_minMode();
    Vector3 myPos;
    int i;
    Vector2 velocity; 
    // Use this for initialization
    void Start() {
        this.mode = this.GetComponent<P_minMode>();
        //velocity = this.GetComponent<Rigidbody>().velocity;
    }

    // Update is called once per frame
    void Update() {
        //this.moveVec = (new Vector2(PlayerObj.player.transform.position.x, PlayerObj.player.transform.position.z) - new Vector2(this.transform.position.x, this.transform.position.z)).normalized * this.speed;
        //this.GetComponent<Rigidbody>().velocity = new Vector3(this.moveVec.x, this.GetComponent<Rigidbody>().velocity.y, this.moveVec.y);
        if (this.mode.p_mode == P_minMode.mode.follow)
        {
            this.moveVec = PlayerObj.player.transform.position - this.transform.position;
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.moveVec.normalized.x * this.speed, this.GetComponent<Rigidbody>().velocity.y, this.moveVec.normalized.z * this.speed);
        }
        else if (this.mode.p_mode == P_minMode.mode.alignment)
        {
            if (this.preMode.p_mode != P_minMode.mode.alignment)
            {
                for (this.i = 0; this.i < 100; this.i++)
                {
                    if (PlayerObj.player.GetComponent<AlignmentPosition>().inPosition[this.i] == false)
                    {
                        PlayerObj.player.GetComponent<AlignmentPosition>().inPosition[this.i] = true;
                        break;
                    }
                }
                Debug.Log(i);
            }
            this.myPos = PlayerObj.player.GetComponent<AlignmentPosition>().posObj[this.i].transform.position;
            //Debug.Log(this.transform.name + ","+ myPos);
            this.GetComponent<Rigidbody>().velocity = (this.myPos - this.transform.position).normalized * this.speed;
        }
        if (this.preMode.p_mode == P_minMode.mode.alignment && this.mode.p_mode != P_minMode.mode.alignment)
        {
            PlayerObj.player.GetComponent<AlignmentPosition>().inPosition[this.i] = false;
        }
        else if (this.mode.p_mode == P_minMode.mode.avoidance)
        {
            Vector3 tmp = Vector3.Cross(this.GetComponent<Rigidbody>().velocity.normalized, new Vector3(0, 1, 0)).normalized;
            //this.GetComponent<Rigidbody>().velocity = new Vector3(tmp.x * speed , this.GetComponent<Rigidbody>().velocity.y, tmp.z * speed);
            this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-4, 4) * speed, this.GetComponent<Rigidbody>().velocity.y, Random.Range(-4, 4) * speed);
        }
        this.preMode.p_mode = this.mode.p_mode;

        //switch (this.mode.p_mode)
        //{
        //    case P_minMode.mode.follow:
        //        this.moveVec = player.transform.position - this.transform.position;
        //        this.GetComponent<Rigidbody>().velocity = new Vector3(this.moveVec.normalized.x * this.speed, this.GetComponent<Rigidbody>().velocity.y, this.moveVec.normalized.z * this.speed);
        //        break;
        //    case P_minMode.mode.alignment:
        //        if (this.preMode.p_mode != P_minMode.mode.alignment)
        //        {
        //            for (this.i = 0; this.i < 100; this.i++)
        //            {
        //                if (player.GetComponent<AlignmentPosition>().inPosition[this.i] == false)
        //                {
        //                    player.GetComponent<AlignmentPosition>().inPosition[this.i] = true;
        //                    break;
        //                }
        //            }
        //        }
        //        else if(this.preMode.p_mode == P_minMode.mode.alignment)
        //        {
        //            player.GetComponent<AlignmentPosition>().inPosition[this.i] = false;
        //        }
        //        this.myPos = player.GetComponent<AlignmentPosition>().posObj[this.i].transform.position;
        //        //Debug.Log(this.transform.name + ","+ myPos);
        //        this.GetComponent<Rigidbody>().velocity = (this.myPos - this.transform.position).normalized * this.speed;
        //        break;
        //    case P_minMode.mode.avoidance:
        //        Vector3 tmp = Vector3.Cross(this.GetComponent<Rigidbody>().velocity.normalized, new Vector3(0, 1, 0)).normalized;
        //        //this.GetComponent<Rigidbody>().velocity = new Vector3(tmp.x * speed , this.GetComponent<Rigidbody>().velocity.y, tmp.z * speed);
        //        this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-1, 1) * speed, this.GetComponent<Rigidbody>().velocity.y, Random.Range(-1, 1) * speed * speed);
        //        break;
        //    default:
        //        break;
        //}

    }

}
