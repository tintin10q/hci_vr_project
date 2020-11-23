using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
	public Transform TeleportTarget;
	public GameObject Player;
	
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Player.transform.position=TeleportTarget.transform.position;
    }
}
