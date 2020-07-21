using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static float gameSpeed = 1;
    [SerializeField]
    //Players _players;
    [Range(2,4)]
    public static int PN;
    public static List<GameObject> players;
    public static GameObject[] Cells;
    public static Transform[] ways;
    public GameObject gm;
    public static GameObject whoesTurn;
    public GameObject WinningWindow;

    // Start is called before the first frame update
    void Awake()
    {
        gameSpeed = 1;
        players = new List<GameObject>();
        //set players
        //PN = 2;
        for (int i = 0; i < PN; i++)
        {
            players.Add(Players.players[i]);
            players[i].SetActive(true);
        }
        

        //set cells
        Cells = new GameObject[100];
        ways = new Transform[100];

        for (int i = 0; i < 100; i++)
        {
            Cells[i] = gm.GetComponent<GridManager>().Cells[i];
            ways[i] = Cells[i].transform;
        }
    }

    internal static void Action(int pos)
    {
        Next();
    }

    void Start()
    {
        whoesTurn = players[0];
 
    }
    
    public void GameSpeed(float value)
    {
        if (value == 0) value = 0.5f;
        gameSpeed = value;
    }



    public static void Next()
    {

        if (whoesTurn == players[players.Count - 1]) whoesTurn = players[0];
        else
        {
            for (int i = 0; i < players.Count-1; i++)
            {
                if (whoesTurn == players[i])
                {
                    whoesTurn = players[i + 1]; break;
                }
            }
        }
        Dice.btn.gameObject.GetComponent<Image>().color = whoesTurn.GetComponent<SpriteRenderer>().color;
    }
}
