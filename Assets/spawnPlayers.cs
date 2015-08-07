using UnityEngine;
using System.Collections;

public class spawnPlayers : MonoBehaviour {

    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
	// Use this for initialization
	void Start () {

        Instantiate(player1, new Vector3(-10, 0, 0), Quaternion.identity);
        Instantiate(player2, new Vector3(10, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
