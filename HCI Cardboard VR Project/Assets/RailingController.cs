using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailingController : MonoBehaviour
{
    public Transform railingContainer;
    
    private Vector3 pos;

    public void onButtonClick_THISONBUTTONCLICK()
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
            pos.y = -20;
            railingContainer.localPosition = pos;
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
