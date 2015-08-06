using UnityEngine;
using System.Collections;

public class projectileBehaviour : MonoBehaviour {

    private Rigidbody2D rb;

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
        if(col.tag == "Player")
        {
            Debug.Log(col.gameObject.name + " Lost A Life");
        }
    }
}
