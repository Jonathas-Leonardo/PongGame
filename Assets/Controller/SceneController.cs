using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

	public GameObject LeftPong_Pos, RightPong_Pos, Ball_Pos;
	public Pong pong_left_obj, pong_right_obj;
	public Ball ball_obj;
	public Text score_a_txt, score_b_txt;

	// Use this for initialization
	void Start () {
		Instantiate (ball_obj, Ball_Pos.transform.position, Ball_Pos.transform.rotation);
		Instantiate (pong_left_obj, LeftPong_Pos.transform.position, LeftPong_Pos.transform.rotation);
		Instantiate (pong_right_obj, RightPong_Pos.transform.position, RightPong_Pos.transform.rotation);

		score_a_txt.text = "0"; //GameManager.current.score_a.ToString ();
		score_b_txt.text = "0"; //GameManager.current.score_b.ToString ();
	}

	void Update () {
		UpdateScore_A (pong_left_obj);
		UpdateScore_B (pong_right_obj);
	}

	public void UpdateScore_A (Player player) {
		score_a_txt.text = player.score.ToString ();
	}

	public void UpdateScore_B (Player player) {
		score_b_txt.text = player.score.ToString ();
	}

	void RestartScene () {
		SceneManager.LoadScene ("Game");
	}
}