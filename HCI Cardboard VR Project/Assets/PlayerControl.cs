using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Transform TeleportTarget;
	public GameObject Player;
	public Transform Player2;

	public float speed = 3.5f;
	private float gravity = 10f;
	private CharacterController controller;
	

	// Start is called before the first frame update
	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update()
    {
		PlayerMovement();        
		if (Player2.localPosition.y < -3)
        {
			Player.transform.position = TeleportTarget.transform.position;
		}
	}

	void PlayerMovement()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontal, 0, vertical);
		Vector3 velocity = direction * speed;
		velocity = Camera.main.transform.TransformDirection(velocity);
		velocity.y -= gravity;
		controller.Move(velocity * Time.deltaTime);
	}
}
