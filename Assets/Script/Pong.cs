using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : Player {

	//public bool isLeft;
	Rigidbody rb;

	public string axis_y, axis_x;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		speed = 100 * speed;
	}

	private void FixedUpdate () {
		Move_X ();
		Move_Y ();
	}

	void Move_Y () {
		float move_y = Input.GetAxis (axis_y) * speed * Time.deltaTime;
		rb.velocity = new Vector3 (rb.velocity.x, move_y, rb.velocity.z);
	}

	void Move_X () {
		float move_x = Input.GetAxis (axis_x) * speed * Time.deltaTime;
		rb.velocity = new Vector3 (move_x, rb.velocity.y, rb.velocity.z);
	}
}