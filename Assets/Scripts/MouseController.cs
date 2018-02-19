using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {

    public GameObject PathfindingObject;

    public Player Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Test -1");
        objectIsHit();
        Debug.Log("Test -2");
    }

    public void objectIsHit()
    {
        Debug.Log("Test");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Test2");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            Debug.Log("Test3");
            if (hit)
            {
                Debug.Log("Test4");
                if (hit.transform.tag == "Selectable")
                {
                    Debug.Log("Selectable");
                    Player.SelectedObject = hit.transform.gameObject;
                }
                else if (hit.transform.tag == "Node")
                {
                    Debug.Log("Node");
                    PathfindingObject.GetComponent<Move>().BasicMove(Player.SelectedObject, hit.transform.gameObject);
                }
            }
            else
            {
                Debug.Log("No hit");
            }
        }
    }
}
