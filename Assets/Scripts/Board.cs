using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    //public Vector2[] Snakes;
    //public Vector2[] Ladders;

    //public static float gameSpeed = 1;
    //public static List<GameObject> players;
    //public static GameObject[] Cells;
    //public static Transform[] ways;
    //private GridManager gridManager;


    //public static GameObject whoesTurn;

    //void Awake()
    //{
    //    gameSpeed = 1;
    //    players = new List<GameObject>();
    //    //set players
    //    //PN = 2;
    //    for (int i = 0; i < Manager.PN; i++)
    //    {
    //        players.Add(Players.players[i]);
    //        players[i].SetActive(true);
    //    }


    //    //set cells
    //    Cells = new GameObject[100];
    //    ways = new Transform[100];

    //    gridManager = GetComponent<GridManager>();

    //    for (int i = 0; i < 100; i++)
    //    {
    //        Cells[i] = gridManager.Cells[i];
    //        ways[i] = Cells[i].transform;
    //    }

    //    whoesTurn = players[0];
    //}

    //internal static void Action(int pos)
    //{
    //    Next();
    //}

    //void Start()
    //{
        

    //}

    //public void GameSpeed(float value)
    //{
    //    if (value == 0) value = 0.5f;
    //    gameSpeed = value;
    //}

    //public static void Next()
    //{

    //    if (whoesTurn == players[players.Count - 1]) whoesTurn = players[0];
    //    else
    //    {
    //        for (int i = 0; i < players.Count - 1; i++)
    //        {
    //            if (whoesTurn == players[i])
    //            {
    //                whoesTurn = players[i + 1]; break;
    //            }
    //        }
    //    }
    //    //Dice.btn.gameObject.GetComponent<Image>().color = whoesTurn.GetComponent<SpriteRenderer>().color;
    //}


}
