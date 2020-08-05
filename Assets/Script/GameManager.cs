using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager current;
	public int score_a, score_b;

	void Awake () {
		GameManager.current = this;
		score_a = 0;
		score_b = 0;
	}

	// Update is called once per frame
	void Update () { }

	void Restart () {
		//score_a = pong_Left.score;
		SceneManager.LoadScene ("Game");
	}
}