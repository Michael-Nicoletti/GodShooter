using UnityEngine;
using System.Collections;

public class RoundTimer : MonoBehaviour {
    public float timer = 120.0f;
    public int rounds = 3;
    public bool roundEnded = false;

    private float timeBeforeNextRound = 5.0f;
    private float originalTimeBeforeNextRound;
    private float originalTimer;
    private GameObject[] players;
	// Use this for initialization
	void Start () {
        originalTimer = timer;
        originalTimeBeforeNextRound = timeBeforeNextRound;

        players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Time: " + timer/60);

        if (!roundEnded)
        {
            timer -= Time.deltaTime;
        }
        
        if (roundEnded && rounds > 0)
        {
            timeBeforeNextRound -= Time.deltaTime;
        }

        if (timer < 0)
        {
            roundEnded = true;
            rounds--;

            timer = originalTimer;
        }
        if (timeBeforeNextRound < 0)
        {
            roundEnded = false;

            timeBeforeNextRound = originalTimeBeforeNextRound;
        }
	}
}
