using UnityEngine;
using System.Collections;

public class GravitySwitch : MonoBehaviour {
    private GameObject[] players;

    // Use this for initialization
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject == players[0] || c.gameObject == players[1] || c.gameObject == players[2] || c.gameObject == players[3])
        {
            Debug.Log("Gravity Switched");
            Physics2D.gravity = -Physics2D.gravity;

            Debug.Log(Physics2D.gravity);
        }
    }
}
