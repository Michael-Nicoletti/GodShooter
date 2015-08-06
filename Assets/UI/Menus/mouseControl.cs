using UnityEngine;
using System.Collections;

public class mouseControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            mouseHandler();
        }
	
	}

    void mouseHandler()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.collider.name == "PlayButton")
            {
                Debug.Log("PLAY BALL");
            }

            if (hit.collider.name == "Controls")
            {
                Debug.Log("DO THE CONTROLS");
            }

            if (hit.collider.name == "Quit")
            {
                Debug.Log("GTFO");
            }
            if(hit.collider.name == "returnToMenu")
            {
                Debug.Log("GO BACK");
            }
        }
    }
}
