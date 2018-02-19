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

    public void BasicMove(GameObject SelectedObject, GameObject Destination)
    {
        while (Destination.GetComponent<Node>().HeldObject != SelectedObject)
        {
            if (SelectedObject.transform.position.x < Destination.transform.position.x) // Déplacement vers le haut
            {
                Debug.Log("up");
                Teleport(SelectedObject, Destination.GetComponent<Node>().AdjacentsNodes[0]);
            }
            else if (SelectedObject.transform.position.x > Destination.transform.position.x) // Déplacement vers le bas
            {
                Debug.Log("down");
                Teleport(SelectedObject, Destination.GetComponent<Node>().AdjacentsNodes[2]);
            }
            else if (SelectedObject.transform.position.y < Destination.transform.position.y) // Déplacement vers la gauche
            {
                Debug.Log("left");
                Teleport(SelectedObject, Destination.GetComponent<Node>().AdjacentsNodes[3]);
            }
            else if (SelectedObject.transform.position.y > Destination.transform.position.y) // Déplacement vers la droite
            {
                Debug.Log("right");
                Teleport(SelectedObject, Destination.GetComponent<Node>().AdjacentsNodes[1]);
            }
        }
    }
}
