using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class healthUIMonitor : MonoBehaviour {

    [SerializeField] GameObject player;
    [SerializeField] Sprite threeHits;
    [SerializeField] Sprite twoHits;
    [SerializeField] Sprite oneHit;
    [SerializeField] Sprite empty;

    Image image;


	void Start () {

        image = GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update () {

        if(player.GetComponent<playerMovement>().getHp() == 3)
        {
            image.sprite = threeHits;
        }
        else if (player.GetComponent<playerMovement>().getHp() == 2)
        {
            image.sprite = twoHits;
        }
        if (player.GetComponent<playerMovement>().getHp() == 1)
        {
            image.sprite = oneHit;
        }
        if(player.GetComponent<playerMovement>().getHp() == 0)
        {
            image.sprite = empty;
        }
	
	}
}
