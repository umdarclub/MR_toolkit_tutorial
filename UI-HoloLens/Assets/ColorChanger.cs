using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    public GameObject mySphere; 

	// Use this for initialization
	void Start () {
		
	}
	
    public void colorBlue()
    {
        Renderer rend = mySphere.GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }
    public void colorGreen()
    {
        Renderer rend = mySphere.GetComponent<Renderer>();
        rend.material.color = Color.green;
    }

    public void colorRed()
    {
        Renderer rend = mySphere.GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

}
