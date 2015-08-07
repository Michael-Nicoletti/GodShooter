using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
    
    //Player 1 or 2 settings
    public int player = 1;
    
    //Movement speed setters
    [SerializeField] int moveSpeed = 20;
    [SerializeField] int maxXVelocity = 100;
    [SerializeField] float jumpSpeed;

    [SerializeField] Animator animPluto;

    //[SerializeField] Animation animMars;


    //Player input values
    private float playerInput;
    private Rigidbody2D rb;
    private bool canJump = true;
    private int playerHealth = 3;
    float movementAmount;
	
    
    // Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

        playerHealth = 3;
	
	}
	
	// Update is called once per frame
	void Update () {

        if(player == 1)
        {
            playerInput = Input.GetAxisRaw("Horizontal");

            //ANIMATION STUFF
            if(playerInput > 0)
            {
                Debug.Log("DO THE THING");
                gameObject.transform.localScale = new Vector3(-1, 1, 1);
                animPluto.SetBool("isWalking", true);
            }
            else if(playerInput < 0)
            {
                Debug.Log("DO THE THING");
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                animPluto.SetBool("isWalking", true);
            }
            else
            {
                animPluto.SetBool("isWalking", false);
            }
            //ANIMATION STUFF END

            if(rb.velocity.x < maxXVelocity)
            {

                rb.AddForce(Vector2.right * moveSpeed * playerInput);
            }

            if (Input.GetKeyDown(KeyCode.W) && canJump == true)
            {
                canJump = false;
                animPluto.SetBool("isJumping", true);
                rb.AddForce(transform.up * jumpSpeed * 100);
            }
            else
                animPluto.SetBool("isJumping", false);
        }

        if(player == 2)
        {
            playerInput = Input.GetAxisRaw("Horizontal2");

            if (rb.velocity.x < maxXVelocity)
            {
                rb.AddForce(Vector2.right * moveSpeed * playerInput);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) && canJump == true)
            {
                canJump = false;
                rb.AddForce(transform.up * jumpSpeed * 100);
            }
        }
        
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag != "Wall")
        {
            canJump = true;
        }
    }

    public int getHp()
    {
        return playerHealth;
    }

    public void subtractHp()
    {
        playerHealth--;
    }
}
