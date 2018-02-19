using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject OnNode;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Teleport(GameObject SelectedObject, GameObject Destination)
    {
        Debug.Log("TP");
        Destination.GetComponent<Node>().HeldObject = SelectedObject;
        SelectedObject.GetComponent<Move>().OnNode.GetComponent<Node>().HeldObject = null;
        SelectedObject.GetComponent<Move>().OnNode = Destination;
        SelectedObject.transform.position = Destination.transform.position;
    }

    public IEnumerator BasicMove(GameObject SelectedObject, GameObject Destination)
    {
        Debug.Log("ordonee:" + SelectedObject.transform.position.y + " " + Destination.transform.position.y);
        Debug.Log("abs:" + SelectedObject.transform.position.x + " " + Destination.transform.position.x);

        var currentNode = SelectedObject.GetComponent<Move>().OnNode;
        if (currentNode.transform.position.y < Destination.transform.position.y) // Déplacement vers le haut
        {
            Debug.Log("up");
            Teleport(SelectedObject, currentNode.GetComponent<Node>().AdjacentsNodes[0]);
        }
        else if (currentNode.transform.position.y > Destination.transform.position.y) // Déplacement vers le bas
        {
            Debug.Log("down");
            Teleport(SelectedObject, currentNode.GetComponent<Node>().AdjacentsNodes[2]);
        }
        else if (currentNode.transform.position.x > Destination.transform.position.x) // Déplacement vers la gauche
        {
            Debug.Log("left");
            Teleport(SelectedObject, currentNode.GetComponent<Node>().AdjacentsNodes[3]);
        }
        else if (currentNode.transform.position.x < Destination.transform.position.x) // Déplacement vers la droite
        {
            Debug.Log("right");
            Teleport(SelectedObject, currentNode.GetComponent<Node>().AdjacentsNodes[1]);
        }

        if (currentNode.transform.position != Destination.transform.position)
        {
            yield return new WaitForSeconds(1);
            StartCoroutine(BasicMove(SelectedObject, Destination));
        }

    }
}
