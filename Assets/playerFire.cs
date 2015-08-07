using UnityEngine;
using System.Collections;

public class playerFire : MonoBehaviour {

    //GameObjects
    [SerializeField] GameObject projectile;

    private bool canShoot = true;
    private float timeBetweenShots;

    //Player Fire Direction Settings
    private KeyCode fireDirection;
    public KeyCode leftFire = KeyCode.J;
    public KeyCode upFire = KeyCode.I;
    public KeyCode rightFire = KeyCode.L;
    public KeyCode downFire = KeyCode.K;

	// Use this for initialization
	void Start () {

        timeBetweenShots = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

       transform.rotation = Quaternion.Euler(0, 0, 0);

       if (canShoot == true)
       {
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
           if (Input.GetKeyDown(downFire))
           {
               transform.rotation = Quaternion.Euler(0, 0, -90);
               playerfire();
           }
       }
       else
           timeBetweenShots--;

        if(timeBetweenShots == 0)
        {
            canShoot = true;
        }
  	}

    void playerfire()
    {
        canShoot = false;
        timeBetweenShots = 10;
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
