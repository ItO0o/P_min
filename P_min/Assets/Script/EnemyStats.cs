using UnityEngine;
using System;

//ito
//プレイヤーのステータスクラス

[Serializable]
public class EnemyStatsData : object {
    //プレイヤーの名前  
    public String name;
    //プレイヤーのHP（ヒットポイント、体力）
    public int hp;
    //プレイヤーのHP最大値
    public int mHp;

    public float speed;

    public int weight;
    public int pikminCnt;
    //プレイヤーのオブジェクトデータ
    [SerializeField]
    public GameObject obj;

    public void SetName(String name) {
        this.name = name;
    }

    public void SetHp(int hp) {
        this.hp = hp;
    }

    public void SetMHp(int mHp) {
        this.mHp = mHp;
    }

    public void SetSpeed(float tempSpeed) {
        speed = tempSpeed;
    }

    public void SetObj(GameObject obj) {
        this.obj = obj;
    }

    public void SetWeight(int weight) {
        this.weight = weight;
    }
    public void SetPkCount(int pikCnt) {
        this.pikminCnt = pikCnt;
    }

    //Getは定義したデータのそれぞれを取得するメソッド
    public String GetName() {
        return name;
    }

    public int GetHp() {
        return hp;
    }

    public int GetMHp() {
        return this.mHp;
    }

    public float GetSpeed() {
        return this.speed;
    }

    public GameObject GetObj() {
        return this.obj;
    }

    public int GetWeight() {
        return this.weight;
    }

    public int GetPikminCnt() {
        return this.pikminCnt;
    }
    //一括取得（いらない気もするけど一応）
    public string GetNormalData() {
        return "hp: " + hp +  " obj: " + obj;
    }
    //Jsonの形そのままで取得
    public string GetJsonData() {
        return JsonUtility.ToJson(this);
    }

}
