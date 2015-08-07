using UnityEngine;
using System.Collections;

public class RoundTimer : MonoBehaviour {
    public float timer = 180.0f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Time: " + timer/60);

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Time.timeScale = 0;
        }
	}
}
