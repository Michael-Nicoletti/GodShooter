using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class roundImageSetter : MonoBehaviour {

    [SerializeField] Sprite oneRound;
    [SerializeField] Sprite twoRounds;
    [SerializeField] Sprite empty;
    [SerializeField] GameObject player;

    Image image;
    playerMovement pMov;

	// Use this for initialization
	void Start () {

        pMov = player.GetComponent<playerMovement>();
        image = GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update () {

        if (pMov.getRoundWins() == 1)
        {
            image.sprite = oneRound;
        }
        else if (pMov.getRoundWins() == 2)
        {;
            image.sprite = twoRounds;
        }
        else
            image.sprite = empty;

	
	}
}
