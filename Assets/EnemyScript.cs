using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public int enemyHP = 100;

	void Start () {

		Debug.Log ("敵のHPは" + enemyHP);
	}
	
	void Update () {

		if (enemyHP == 0) {

			Debug.Log ("clear");
		}
	}

	private void OnCollisionEnter(Collision collision) {

		enemyHP--;
		Debug.Log ("敵のHPは" + enemyHP);
	
	}
}
