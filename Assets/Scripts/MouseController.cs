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
        objectIsHit();
    }

    public void objectIsHit()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                if (hit.transform.tag == "Selectable")
                {
                    Player.SelectedObject = hit.transform.gameObject;
                }
                else if (hit.transform.tag == "Node")
                {
                    PathfindingObject.GetComponent<Move>().Teleport(Player.SelectedObject, hit.transform.gameObject);
                }
            }
            else
            {
                Debug.Log("No hit");
            }
        }
    }
}
