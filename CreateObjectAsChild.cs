using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script allows to make a new object as child of an existing object in the scene
    To use:
    Attach this script to the parent object in the scene. In inspector, drag the future child object
    to childObj.
    */


public class Test : MonoBehaviour {

    public GameObject childObj;

    // Use this for initialization
    void Start() {
        childObj = new GameObject("name");
        childObj.transform.parent = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
