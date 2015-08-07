using UnityEngine;
using System.Collections;

public class GravityManipulation : MonoBehaviour {
    private GameObject[] players;

	// Use this for initialization
	void Start () {
        players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject == players[0] || c.gameObject == players[1] || c.gameObject == players[2] || c.gameObject == players[3])
        {
            Debug.Log("Gravity Manipulated");
            float gravityChange = Random.Range(-1, 1);

            Physics2D.gravity += new Vector2(0, gravityChange);

            Debug.Log(Physics2D.gravity);
        }
    
    }
}
