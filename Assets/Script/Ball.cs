using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float speed_x;
	public float speed_y;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		speed_x = speed_x * 100 * (Random.Range (-1, 1) == 0 ? 1 : -1);
		speed_y = speed_y * 100 * (Random.Range (-1, 1) == 0 ? 1 : -1);
		rb = GetComponent<Rigidbody> ();
		Walk ();
	}

	void Walk () {
		Vector3 vec = new Vector3 (speed_x * Time.deltaTime, speed_y * Time.deltaTime, 0);
		rb.AddForce (vec, ForceMode.Impulse);
	}
}