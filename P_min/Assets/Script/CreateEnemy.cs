using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour {

    private EnemyStatsData enemy = new EnemyStatsData();

    public bool dead = false;

    public EnemyStatsData GetEnemy() {
        return this.enemy;
    }

    // Use this for initialization
    void Start () {
        this.enemy.SetHp(100);
        this.enemy.SetMHp(100);
        this.enemy.SetObj(this.gameObject);
        this.enemy.SetName("Enemy");
        this.enemy.SetSpeed(1);
        this.enemy.SetWeight(3);
        this.enemy.SetPkCount(0);
	}
	
	// Update is called once per frame
	void Update () {
        if (this.enemy.GetHp() <= 0) {
            this.dead = true;
        }
    }
}
