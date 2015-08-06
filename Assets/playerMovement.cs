using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
    
    //Player 1 or 2 settings
    public int player = 1;
    
    //Movement speed setters
    [SerializeField] int moveSpeed = 20;
    [SerializeField] float jumpSpeed;

    //Player input values
    private float playerInput;
    private Rigidbody2D rb;
    private bool canJump = true;
	
    
    // Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if(player == 1)
        {
            playerInput = Input.GetAxisRaw("Horizontal");

            rb.AddForce(Vector2.right * moveSpeed * playerInput);

            if (Input.GetKeyDown(KeyCode.W) && canJump == true)
            {
                canJump = false;
                rb.AddForce(Vector2.up * jumpSpeed * 100);
            }
        }

        if(player == 2)
        {
            playerInput = Input.GetAxisRaw("Horizontal2");

            rb.AddForce(Vector2.right * moveSpeed * playerInput);

            if (Input.GetKeyDown(KeyCode.UpArrow) && canJump == true)
            {
                canJump = false;
                rb.AddForce(Vector2.up * jumpSpeed * 100);
            }
        }
        
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "ground")
        {
            canJump = true;
        }
    }
}
