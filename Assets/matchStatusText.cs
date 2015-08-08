using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class matchStatusText : MonoBehaviour {

    [SerializeField] Sprite matchStart;
    [SerializeField] Sprite pOneWin;
    [SerializeField] Sprite pTwoWin;
    [SerializeField] Sprite empty;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    private bool matchIsStarting = true;

    Image image;

	// Use this for initialization
	void Start () {

        image = GetComponent<Image>();
        //image.sprite = empty;
	
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(player1.GetComponent<playerMovement>().getRoundWins());

        if(matchIsStarting == true)
        {
            image.sprite = matchStart;
            StartCoroutine(removeSprite());
            //image.sprite = empty;
            Debug.Log("Is this happening");
            matchIsStarting = false;
            
        }

        if(player1.GetComponent<playerMovement>().getHp() == 0)
        {
            image.sprite = pTwoWin;
            player2.GetComponent<playerMovement>().setRoundWins();
            StartCoroutine(waitForRespawn());
        }
        else if(player2.GetComponent<playerMovement>().getHp() == 0)
        {
            image.sprite = pOneWin;
            player1.GetComponent<playerMovement>().setRoundWins();
            StartCoroutine(waitForRespawn());
        }
	}

    IEnumerator removeSprite()
    {
        yield return new WaitForSeconds(3);
        image.sprite = empty;
    }

    IEnumerator waitForRespawn()
    {
        yield return new WaitForSeconds(5);
        matchIsStarting = true;
        player1.gameObject.SetActive(true);
        player2.gameObject.SetActive(true);
        player1.GetComponent<playerMovement>().resetPlayer();
        player2.GetComponent<playerMovement>().resetPlayer();
        Debug.Log("Is this running?");
    }
}
