using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class matchStatusText : MonoBehaviour {

    [SerializeField] Sprite matchStart;
    [SerializeField] Sprite pOneWin;
    [SerializeField] Sprite pTwoWin;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    private bool matchIsStarting = true;

    Image image;

	// Use this for initialization
	void Start () {

        //image.sprite = null;
	
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(Time.time);

        if(matchIsStarting == true)
        {
            //image.sprite = matchStart;
            StartCoroutine(removeSprite());
            //image.sprite = pTwoWin;
            Debug.Log("Is this happening");
            
        }

        if(player1.GetComponent<playerMovement>().getHp() == 0)
        {
            image.sprite = pTwoWin;
        }
        else if(player2.GetComponent<playerMovement>().getHp() == 0)
        {
            image.sprite = pOneWin;
        }
	}

    IEnumerator removeSprite()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Is this running?");
    }
}
