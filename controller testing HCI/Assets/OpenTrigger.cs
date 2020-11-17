using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTrigger : MonoBehaviour
{
	public Transform OpenDoor;
	public GameObject Door;
	public Vector3 moveDirection;
	
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
		Door.transform.position += moveDirection;
    }
	void OnTriggerExit(Collider other)
	{
		Door.transform.position -= moveDirection;
	}
}
