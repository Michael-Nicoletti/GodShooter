using UnityEngine;
using System.Collections;

public class projectileBehaviour : MonoBehaviour {

    private Rigidbody2D rb;
    [SerializeField] int player;
    [SerializeField] int bulletSpeed = 10;

    [SerializeField] Animator animController;

    //[SerializeField]
    //[SerializeField] Sprite plutoHpPanel;

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
            if (col.name == "player 2" || col.name == "player 2(clone)")
            {
                if (col.gameObject.GetComponent<Invulrability>().invulrable == false)
                {
                    Debug.Log(col.gameObject.name + " Lost A Life");

                    animController.SetBool("hit", true);

                    col.gameObject.GetComponent<playerMovement>().subtractHp();

                    col.gameObject.GetComponent<Invulrability>().invulrable = true;
                }

                Destroy(gameObject);
            }
        }

        if (player == 2)
        {
            if (col.name == "player 1" || col.name == "player 1(clone)")
            {
                if (col.gameObject.GetComponent<Invulrability>().invulrable == false)
                {
                    Debug.Log(col.gameObject.name + " Lost A Life");

                    animController.SetBool("hit", true);

                    col.gameObject.GetComponent<playerMovement>().subtractHp();

                    col.gameObject.GetComponent<Invulrability>().invulrable = true;
                }

                Destroy(gameObject);
            }
        }

        if(col.tag == "Wall")
        {
            animController.SetBool("hit", true);

            Destroy(gameObject);
        }
        
    }
}
