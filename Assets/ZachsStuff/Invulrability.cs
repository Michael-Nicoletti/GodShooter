using UnityEngine;
using System.Collections;

public class Invulrability : MonoBehaviour {
    public float invulrableTime = 1.0f;
    public bool invulrable = false;

    private playerMovement healthScript;
    private int playerHealth;
    private float originalInvulrableTime;
	// Use this for initialization
	void Start () {
        healthScript = GetComponent<playerMovement>();
        originalInvulrableTime = invulrableTime;
	}
	
	// Update is called once per frame
	void Update () {
        playerHealth = healthScript.getHp();

        if (invulrable)
        {
            invulrableTime -= Time.deltaTime;

            if (invulrableTime <= 0)
            {
                invulrable = false;
                invulrableTime = originalInvulrableTime;
            }
        }
	}
}
