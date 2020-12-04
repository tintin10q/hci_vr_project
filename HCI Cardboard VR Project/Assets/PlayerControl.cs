using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Transform TeleportTarget;
    public Transform TeleportTarget1;
    public Transform TeleportTarget2;
    public Transform TeleportTarget3;
    public Transform GlobalStorage;
    
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
			switch (GlobalStorage.position.y) // There must be some way to do globals for now this is it :\
			{
				case 0:
					Player.transform.position = TeleportTarget.transform.position;
					break;
				case 1:
					Player.transform.position = TeleportTarget1.transform.position;
					break;
				case 2:
					Player.transform.position = TeleportTarget2.transform.position;
					break;
				case 3:
					Player.transform.position = TeleportTarget3.transform.position;
					break;
			}
			// Player.transform.position = TeleportTarget.transform.position;
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
