using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonController : MonoBehaviour
{
   public Transform targetBridge;
   public Transform removeBridge1;
   public Transform removeBridge2;

   private Vector3 showPos = new Vector3(0, 0, 0);
   private Vector3 awayPos = new Vector3(0, -20, 0);
   
   
   public void ButtonPressCALLTHISONE_ONCLICK()
   {
      // removeBridge1.SetActive(false);
      // removeBridge2.SetActive(false);
      // targetBridge.SetActive(true);
      targetBridge.localPosition = showPos;
      removeBridge1.localPosition = awayPos;
      removeBridge2.localPosition = awayPos;
      GetComponent<Renderer>().material.color = Color.red;
   }
   
   private void Update() // set color back to white when bridge is lower
   {
      if (targetBridge.localPosition.y < 0) // Set color back to white if button is "unpressed"
      {
         GetComponent<Renderer>().material.color = Color.white;
      }
   }
}
