using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	int launchCount = 0;
	int playerHP = 100;
	// Use this for initialization
	void Start () {

		Debug.Log ("プレイヤーHPは" + playerHP);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("up")) {

			if (gameObject.GetComponent<Rigidbody>().velocity == new Vector3(0,0,0)) {
		
				gameObject.GetComponent<Rigidbody> ().velocity = transform.forward * 50f;
				launchCount += 1;
				Debug.Log (launchCount);
			}
		}

		if (gameObject.GetComponent<Rigidbody>().velocity == new Vector3(0,0,0)) {

			transform.Rotate (new Vector3 (0, 1f, 0));
		}

		if (playerHP == 0) {
			Debug.Log ("GameOver");
		}
	}

	private void OnTriggerEnter(Collider other) {
	
		playerHP--;
		Debug.Log ("プレイヤーのHPは" + playerHP);
	}
}
