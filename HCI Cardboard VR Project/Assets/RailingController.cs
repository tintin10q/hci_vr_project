using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailingController : MonoBehaviour
{
    public Transform railingContainer;
    
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
    