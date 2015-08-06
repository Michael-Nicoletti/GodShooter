using UnityEngine;
using System.Collections;

public class playerFire : MonoBehaviour {

    //GameObjects
    [SerializeField] GameObject projectile;

    //Player Fire Direction Settings
    private KeyCode fireDirection;
    public KeyCode leftFire = KeyCode.J;
    public KeyCode upFire = KeyCode.I;
    public KeyCode rightFire = KeyCode.L;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.Euler(0, 0, 0);
       
        if (Input.GetKeyDown(leftFire))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            playerfire();
        }
        if (Input.GetKeyDown(upFire))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            playerfire();
        }
        if (Input.GetKeyDown(rightFire))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            playerfire();
        }
  	}

    void playerfire()
    {

        Instantiate(projectile, transform.position, transform.rotation);
    }
}
