using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public Rigidbody2D targ;
	public float speed = 1;

	// Use this for initialization
	void Start () {
		if(targ == null)
			targ = this.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.DownArrow)) {
			targ.AddForce(Vector2.down * speed);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			targ.AddForce(Vector2.up * speed);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			targ.AddForce(Vector2.right * speed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			targ.AddForce(Vector2.left * speed);
		}
	}
}