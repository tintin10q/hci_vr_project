using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Transform TeleportTarget;
	public GameObject Player;
	public Transform Player2;
	public GameObject bs;

	public float speed = 2f;
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
			bs.SetActive(true);
			Player.transform.position = TeleportTarget.transform.position;
			Invoke("GoBlack", 2);
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

	void GoBlack()
	{
		bs.SetActive(false);
	}
}
