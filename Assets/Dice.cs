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
        btn.gameObject.GetComponent<Image>().color = Manager.whoesTurn.GetComponent<SpriteRenderer>().color;
        btn.interactable = true;
        diceImage.sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator MakeRandomDiceFaces()
    {
        DiceSpeed = 0.05f;

        for (int i = 0; i < 15; i++)
        {
            int med = Random.Range(0, 6);
            //slowMotion at the End
            DiceSpeed += 0.005f;
            SoundManager.Play("step");
            yield return new WaitForSeconds(DiceSpeed);
            diceImage.sprite = sprites[med];
            dice = med + 1;
        }
        SoundManager.Play("step");
        if (dice == 6) Manager.whoesTurn.GetComponent<Movement>().rollAgain = true;
            Manager.whoesTurn.GetComponent<Movement>().distance = dice;
        

        //yield return new WaitForSeconds(.5f);
        //Engine.Player().GetComponent<Movement>().Distance(dice);
        //yield return new WaitForSeconds(1f);
            
        
        
    }


    public void ThrowDice()
    {
        gameObject.GetComponent<Button>().interactable = false;
        StartCoroutine(MakeRandomDiceFaces());



    }
}
