using UnityEngine;
using System.Collections;

public class projectileBehaviour : MonoBehaviour {

    private Rigidbody2D rb;

    [SerializeField] int bulletSpeed = 10;

	// Use this for initialization
	void Start () {


        rb = GetComponent<Rigidbody2D>();


        rb.AddForce(transform.right * bulletSpeed);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
