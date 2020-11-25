using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonController : MonoBehaviour
{
    public Transform targetBridge;
    public Transform removeBridge1;
    public Transform removeBridge2;

    private Vector3 pos;
    private Vector3 pos2;
    private Vector3 pos3;

    public void ButtonPressCALLTHISONE_ONCLICK()
    {
        if (targetBridge.localPosition.y < -1)
        {
            pos = targetBridge.localPosition;
            pos2 = removeBridge1.localPosition;
            pos3 = removeBridge2.localPosition;
            pos.y = 0;
            pos2.y = -40;
            pos3.y = -40;
            targetBridge.localPosition = pos;
            removeBridge1.localPosition = pos2;
            removeBridge2.localPosition = pos3;
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            pos = targetBridge.localPosition;
            pos.y = -40;
            targetBridge.localPosition = pos;
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

    private void Update() // set color back to white when bridge is lower
    {
        if (targetBridge.localPosition.y < 0) // Set color back to white if button is "unpressed"
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}