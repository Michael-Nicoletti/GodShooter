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

        //Debug.Log(Time.time);

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
        }
        else if(player2.GetComponent<playerMovement>().getHp() == 0)
        {
            image.sprite = pOneWin;
        }
	}

    IEnumerator removeSprite()
    {
        yield return new WaitForSeconds(3);
        image.sprite = empty;
        Debug.Log("Is this running?");
    }
}
