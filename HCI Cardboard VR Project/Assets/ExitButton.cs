using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitButtonPressCALLTHISONE_ONCLICK()
    {
        Debug.Log("Quit game.");
        Application.Quit();
    }
}
