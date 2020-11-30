using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportTrigger : MonoBehaviour
{
	public Transform TeleportTarget;
	public GameObject Player;
    public GameObject bs;
    public float xAngle, yAngle, zAngle;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        bs.SetActive(true);
        Player.transform.position = TeleportTarget.transform.position;        
        Player.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        Invoke("GoBlack", 2);
    }

    void GoBlack()
    {
        bs.SetActive(false);
    }
}

