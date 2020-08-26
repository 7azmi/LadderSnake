using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{
    public static Button btn;

    public Sprite[] sprites = new Sprite[6];

    public float DiceSpeed;
    public static int dice;
    private Image diceImage;


    void Awake()
    {
        btn = gameObject.GetComponent<Button>();
        diceImage = gameObject.GetComponent<Image>();
    }

    void Start()
    {
        //btn.gameObject.GetComponent<Image>().color = Board.whoesTurn.GetComponent<SpriteRenderer>().color;
        btn.interactable = true;
        diceImage.sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator MakeRandomDiceFaces()
    {
        DiceSpeed = 0.06f - (Board.gameSpeed *.01f);

        int thrownCount = Random.Range(10, 20- (int)(Board.gameSpeed));
        for (int i = 0; i < thrownCount; i++)
        {
            int med;
            do
            {
                med = Random.Range(0, 6); 
            }
            while (med == dice - 1);
            //slowMotion at the End
            DiceSpeed += 0.005f;
            AudioManager.instance.Play("dice");
            yield return new WaitForSeconds(DiceSpeed);
            diceImage.sprite = sprites[med];
            dice = med + 1;
        }
        
        if (dice == 6) AudioManager.instance.Play("dice6");
                  else AudioManager.instance.Play("dice");

        Board.whoesTurn.GetComponent<Movement>().distance = dice;


    }


    public void ThrowDice()
    {
        gameObject.GetComponent<Button>().interactable = false;
        StartCoroutine(MakeRandomDiceFaces());



    }
}
