using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignmentPosition : MonoBehaviour {
    public List<GameObject> posObj = new List<GameObject>();
    public GameObject[] leading5P_min = new GameObject[10];
    public Vector3[] alignmentPos = new Vector3[100];
    public bool[] inPosition = new bool[100];
    GameObject player;
    float x = -2, y = -1.5f;
    //int[] pikminCnt
    // Use this for initialization
    private void Awake() {
        player = GameObject.Find("Player");
        GameObject tmp = Resources.Load<GameObject>("GameObject");
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                inPosition[i * 10 + j] = false;
                alignmentPos[i * 10 + j] = new Vector3(x, 0, y);
                if (i % 2 == 0) {
                    x += 0.8f;
                } else {
                    x -= 0.8f;
                }
            }
            //x = -2;
            y -= 0.4f;
        }



        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                if (i == 0 && j <= 9) {
                    posObj.Add(leading5P_min[j]);
                } else {
                    GameObject instObj = Instantiate(tmp);
                    instObj.transform.position = alignmentPos[i * 10 + j];
                    instObj.transform.parent = GameObject.Find("Alignment_Positions").transform;
                    posObj.Add(instObj);
                }
            }
        }
    }
}
