using UnityEngine;
using System.Collections;

public class projectileBehaviour : MonoBehaviour {

    private Rigidbody2D rb;
    [SerializeField] int player;
    [SerializeField] int bulletSpeed = 10;

	// Use this for initialization
    void Start()
    {
        Destroy(gameObject, 3);

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletSpeed * 100);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(player == 1)
        {
            if (col.name == "player 2")
            {
                Debug.Log(col.gameObject.name + " Lost A Life");
                Destroy(gameObject);
            }
        }

        if (player == 2)
        {
            if (col.name == "player 1")
            {
                Debug.Log(col.gameObject.name + " Lost A Life");
                Destroy(gameObject);
            }
        }

        if(col.tag == "Wall")
        {
            Destroy(gameObject);
        }
        
    }
}
