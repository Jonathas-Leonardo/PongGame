using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public Player player;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			Debug.Log ("Goal " + player.name);
			player.score++;
			//GameManager.current.UpdateScore_A (player);
		}
	}
}