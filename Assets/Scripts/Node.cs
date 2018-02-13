using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    public GameObject [] AdjacentsNodes;

    public GameObject HeldObject;

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
                Instantiate(BaseNode, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }
}
