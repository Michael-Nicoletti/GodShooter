using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
    public bool dead = false;

    private playerMovement healthScript;
    private int playerHealth;

	// Use this for initialization
	void Start () {
        healthScript = GetComponent<playerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        playerHealth = healthScript.getHp();

        if (playerHealth == 0)
        {
            dead = true;

            gameObject.SetActive(false);
        }
	}
}
