using UnityEngine;
using System.Collections;

public class cameraZoom : MonoBehaviour {

    [SerializeField]
    GameObject player1;

    [SerializeField]
    GameObject player2;

    private float xAverage;
    private float yAverage;

    private float prevDistance = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        xAverage = (player1.transform.position.x + player2.transform.position.x) /2;
        yAverage = (player1.transform.position.y + player2.transform.position.y) /2;

            //Debug.Log(Vector3.Distance(player1.transform.position, player2.transform.position));
            if (Camera.main.orthographicSize >= (Vector3.Distance(player1.transform.position, player2.transform.position) / 2) && Camera.main.orthographicSize > 10
                && Vector3.Distance(player1.transform.position, player2.transform.position) < prevDistance)
            {
                Camera.main.orthographicSize -= 15 * Time.deltaTime;
                prevDistance = Vector3.Distance(player1.transform.position, player2.transform.position);
            }
            else if (Camera.main.orthographicSize <= Vector3.Distance(player1.transform.position, player2.transform.position)/2)
            {
                Camera.main.orthographicSize += 15 * Time.deltaTime;
                prevDistance = Vector3.Distance(player1.transform.position, player2.transform.position);
            }
            transform.position = new Vector3(xAverage, yAverage, -10);
	}
}
