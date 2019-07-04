using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowP : MonoBehaviour {

    //List<GameObject> pikmins = new List<GameObject>();
    GameObject player;
    public float jumpPower;
    // Use this for initialization
    void Start() {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.X)) {
            //var childTransform = GameObject.Find("Pikmins").GetComponentsInChildren<Transform>();
            //foreach (Transform child in childTransform) {
            //    if (null != child.GetComponent<Animator>() && pikmins.IndexOf(child.gameObject) == -1) {
            //        pikmins.Add(child.gameObject);
            //    }
            //}
            //GameObject tmp = pikmins[0];
            //float min = (pikmins[0].transform.position - player.transform.position).magnitude;
            //for (int i = 1; i < pikmins.Count - 1; i++) {
                //if (min > (pikmins[i].transform.position - player.transform.position).magnitude) {
                //    min = (pikmins[i].transform.position - player.transform.position).magnitude;
                //    tmp = pikmins[i];
                //}
            //}
            LeadP_minFlag.leadingP_min.GetComponent<Rigidbody>().velocity = new Vector3(player.GetComponent<Rigidbody>().velocity.x * jumpPower,jumpPower, player.GetComponent<Rigidbody>().velocity.z * jumpPower);
            PlayerObj.player.GetComponent<AlignmentPosition>().inPosition[LeadP_minFlag.leadingP_min.GetComponent<PikminMove>().i] = false;
            LeadP_minFlag.leadingP_min.GetComponent<P_minMode>().p_mode = P_minMode.mode.attack;
            //pikmins.Clear();
        }

    }
}