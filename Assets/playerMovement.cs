using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    [SerializeField] int speed;

    private float playerInput;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

        playerInput = Input.GetAxisRaw("Horizontal");

        rb.AddForce(Vector2.right * speed * playerInput);


	
	}
}
