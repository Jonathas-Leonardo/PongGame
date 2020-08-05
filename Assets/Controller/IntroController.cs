using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroController : MonoBehaviour {

	public Image[] options_list;
	public int choice_number = 0;
	public int choice_number_max = 0;
	delegate void SceneOptions ();
	SceneOptions[] sceneOptions;

	// Use this for initialization
	void Start () {
		DisableAll ();
		choice_number_max = options_list.Length - 1;
		sceneOptions = new SceneOptions[] { CallGame, CallOption, CallQuit };
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			sceneOptions[choice_number] ();
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			choice_number = (choice_number > 0) ? choice_number -= 1 : choice_number;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			choice_number = (choice_number < choice_number_max) ? choice_number += 1 : choice_number;
		}
		DisableAll ();
		options_list[choice_number].enabled = true;
	}

	void DisableAll () {
		foreach (Image item in options_list) {
			item.enabled = false;
		}
	}
	void CallGame () {
		Debug.Log (0);
	}
	void CallQuit () {
		Debug.Log (2);
	}
	void CallOption () {
		Debug.Log (1);
	}
}