﻿using UnityEngine;
using System.Collections;

public class GravityManipulation : MonoBehaviour {
    private GameObject[] players;
    private float gravityChange;

	// Use this for initialization
	void Start () {
        players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        gravityChange = Random.Range(-2, 2);
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject == players[0] || c.gameObject == players[1] || c.gameObject == players[2] || c.gameObject == players[3])
        {
            Debug.Log("Gravity Manipulated");

            Physics2D.gravity += new Vector2(0, gravityChange);

            Debug.Log(Physics2D.gravity);
        }
    }
}
