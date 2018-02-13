using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Teleport(GameObject SelectedObject, GameObject Destination)
    {
        Destination.GetComponent<Node>().HeldObject = SelectedObject;
        SelectedObject.transform.position = Destination.transform.position;
    }
}
