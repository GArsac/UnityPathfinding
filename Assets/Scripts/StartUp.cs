using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour {

    public GameObject BaseNode;
    public GameObject BaseObject;

    // Use this for initialization
    void Start () {
        Node.CreateNodes(BaseNode);
        GameObject[] nodes = GameObject.FindGameObjectsWithTag("Node");
        BaseObject.GetComponent<Move>().Teleport(BaseObject, nodes[0]);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
