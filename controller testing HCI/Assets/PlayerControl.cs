using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public float speed = 3.5f;
	private float gravity = 10f;
	private CharacterController controller ;
	
    // Start is called before the first frame update
    void Start()
    {
			controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButton("Fire2") == true){
	   PlayerMovementButton(); }
	   else {PlayerMovementJoystick();}
	   
    }
	
	void PlayerMovementButton()
	{
		//float horizontal = Input.GetAxis("Horizontal");
		//float vertical =  0.5f;
		
		//Vector3 direction = new Vector3(0, 0, 1);
		//Vector3 velocity = direction * speed;
		//velocity = Camera.main.transform.TransformDirection(velocity);
		//velocity.y -= gravity;
		//controller.Move(velocity*Time.deltaTime);
		Vector3 gomove = new Vector3(0, 0, speed) ;
		Camera.main.transform.TransformDirection(gomove);
	}
	
	void PlayerMovementJoystick()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		Vector3 direction = new Vector3(horizontal, 0, vertical);
		Vector3 velocity = direction * speed;
		velocity = Camera.main.transform.TransformDirection(velocity);
		velocity.y -= gravity;
		controller.Move(velocity*Time.deltaTime);
	}
}
