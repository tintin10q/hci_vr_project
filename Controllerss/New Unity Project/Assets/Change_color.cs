using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void Purple()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }
    
    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    
    public void Black()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
    
    
}

