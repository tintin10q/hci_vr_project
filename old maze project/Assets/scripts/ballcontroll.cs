using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroll : MonoBehaviour {

	public float speed;
	private Rigidbody myRigidbody;

	private void Start() {
		myRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		myRigidbody.AddForce(moveHorizontal*speed, 0.0f, moveVertical*speed);
	}
}
