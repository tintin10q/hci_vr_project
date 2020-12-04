using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailingController : MonoBehaviour
{
    public Transform railingContainer;
    public AudioClip clip;
    public float volume=1;
    private Vector3 pos;
        
    public bool gazedAt;
    private float timer;
    public float gazeTime = 1f;

    private void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                if (railingContainer.localPosition.y < -1) // Railing is off
                {
                    pos = railingContainer.localPosition;
                    pos.y = 0;
                    railingContainer.localPosition = pos;
                    GetComponent<Renderer>().material.color = Color.blue;
                }
                else // Railing is off
                {
                    pos = railingContainer.localPosition;
                    pos.y = -40;
                    railingContainer.localPosition = pos;
                    GetComponent<Renderer>().material.color = Color.white;
                }
                AudioSource.PlayClipAtPoint(clip, GetComponent<Transform>().position, volume);
                timer = 0f;
            }
        }
    }
    
    public void PointerEnter()
    {
        gazedAt = true;
    }

    public void PointerExit()
    {
        gazedAt = false;
    }
}
    