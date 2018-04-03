using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCube : MonoBehaviour {

    public GameObject plane ;
    private GameObject obj2; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void create_cube () {
        obj2 = GameObject.Find("MyCube");
        Transform obj_transfrom = plane.GetComponent<Transform>();
        Vector3 pos = new Vector3(obj_transfrom.position.x, obj_transfrom.position.y / 2.0f, obj_transfrom.position.z);
        
        Instantiate(obj2, pos, Quaternion.identity);

    }
}
