using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour {

    public GameObject BaseNode;
    public GameObject BaseObject;

    // Use this for initialization
    void Start () {
        Node.CreateNodes(BaseNode);
        Node.AllNodes = GameObject.FindGameObjectsWithTag("Node");
        Node.LinkNodes();
        BaseObject.GetComponent<Move>().OnNode = Node.AllNodes[0];
        BaseObject.GetComponent<Move>().Teleport(BaseObject, Node.AllNodes[0]);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
