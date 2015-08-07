using UnityEngine;
using System.Collections;

public class GroundShift : MonoBehaviour {
    public float smooth = 2.0f;

    private GameObject[] players;
    private int playerCount;

	// Use this for initialization
	void Start () {
        players = GameObject.FindGameObjectsWithTag("Player");
        playerCount = players.Length;
	}
	
	// Update is called once per frame
	void Update () {
        int leftCount = 0;
        int rightCount = 0;

	    for (int i = 0; i < playerCount; i++)
        {
            if (players[i].transform.position.x > 0)
            {
                rightCount++;
            }
            if (players[i].transform.position.x < 0)
            {
                leftCount++;
            }
        }
        Debug.Log("Left = " + leftCount);
        Debug.Log("Right = " + rightCount);

        if (leftCount > playerCount / 2)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 90), Time.deltaTime * smooth);
        }
        if (rightCount > playerCount / 2)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -90), Time.deltaTime * smooth);
        }
	}
}
