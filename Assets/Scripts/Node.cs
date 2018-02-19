using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    /** LISTE DES NODES ADJACENTES
     * 
     *  0 = Haut
     *  1 = Droite
     *  2 = Bas
     *  3 = Gauche
     * 
     **/
    public GameObject[] AdjacentsNodes;

    public GameObject HeldObject;

    public static GameObject[] AllNodes;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void CreateNodes(GameObject BaseNode)
    {
        for (int i = -5; i < 6; i++)
        {
            for (int j = -4; j < 5; j++)
            {
                GameObject CurrentNode = Instantiate(BaseNode, new Vector3(i, j, 0), Quaternion.identity);
                CurrentNode.name = "Node(" + i + "," + j + ")";
            }
        }
    }

    public static void LinkNodes()
    {
        foreach (GameObject node in AllNodes)
        {
            node.GetComponent<Node>().AdjacentsNodes[0] = GameObject.Find("Node(" + (node.transform.position.x) + "," + (node.transform.position.y + 1) + ")");
            node.GetComponent<Node>().AdjacentsNodes[1] = GameObject.Find("Node(" + (node.transform.position.x + 1) + "," + (node.transform.position.y) + ")");
            node.GetComponent<Node>().AdjacentsNodes[2] = GameObject.Find("Node(" + (node.transform.position.x) + "," + (node.transform.position.y - 1) + ")");
            node.GetComponent<Node>().AdjacentsNodes[3] = GameObject.Find("Node(" + (node.transform.position.x - 1) + "," + (node.transform.position.y) + ")");
        }
    }
}
