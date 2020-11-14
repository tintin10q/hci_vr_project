using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR_camera_move : MonoBehaviour
{
	public Transform vrCamera;
	public float toggleAngle = 30.0f;
	public float speed = 3.0f;
	private bool moveForwards = false;

	private CharacterController myCharacterController;
	public Camera mychamera;

	// Use this for initialization
	void Start()
	{
		myCharacterController = GetComponent<CharacterController>();
		vrCamera = Camera.main.transform;
	}

	// Update is called once per frame
	void Update()
	{
		if (vrCamera.transform.eulerAngles.x >= toggleAngle && vrCamera.transform.eulerAngles.x < 90.0f)
		{
			moveForwards = true;
		}
		else
		{
			moveForwards = false;
		}

		if (moveForwards)
		{
			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
			myCharacterController.SimpleMove(forward * speed);
		}
	}
}
