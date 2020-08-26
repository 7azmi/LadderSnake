using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ChooseBoard : MonoBehaviour
{
    public GameObject lockerPanel;
    public Image choosenBoard;
    public Button left, right;
    public TextMeshProUGUI diffeculty;
    public Board_Card[] cards;
    public Button play;
    

    void Awake()
    {
        cards[2].Locked = true;
        Manager.Board_Card = cards[0];
        choosenBoard.sprite = cards[0].Board;
        diffeculty.text = "Easy";
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Board_Card.Locked)
        {
            lockerPanel.SetActive(true);
            play.interactable = false;
        }
        else
        {
            lockerPanel.SetActive(false);
            play.interactable = true;
        }
    }



    public void Right()
    {
        for (int i = 0; i < cards.Length-1; i++)
        {
            
            if (choosenBoard.sprite == cards[i].Board)
            {
                choosenBoard.sprite = cards[i + 1].Board;
                diffeculty.text = cards[i + 1].boardLevel.ToString();
                Manager.Board_Card = cards[i + 1];
                return;
            }
        }
        choosenBoard.sprite = cards[0].Board;
        diffeculty.text = "Easy";
        Manager.Board_Card = cards[0];
    }
    public void Left()
    {
        for (int i = 2; i > 0; i--)
        {

            if (choosenBoard.sprite == cards[i].Board)
            {
                
                choosenBoard.sprite = cards[i - 1].Board;
                diffeculty.text = cards[i - 1].boardLevel.ToString();
                Manager.Board_Card = cards[i - 1];
                return;
            }
        }
        choosenBoard.sprite = cards[2].Board;
        diffeculty.text = "Hard";
        Manager.Board_Card = cards[2];
    }

    public void Play()
    {
        AudioManager.instance.StopMusic();
        SceneManager.LoadScene("The Game");
    }
}
