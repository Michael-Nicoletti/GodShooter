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

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].transform.rotation.z == 0)
                {
                    players[i].transform.rotation = Quaternion.Slerp(players[i].transform.rotation, Quaternion.Euler(0, 0, 180), 2.0f);
                }
                else
                {
                    players[i].transform.rotation = Quaternion.Slerp(players[i].transform.rotation, Quaternion.Euler(0, 0, 0), 2.0f);
                }
            }
        }
    }
}
