using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    //3 cuz First Player can't be Bot 
    public static bool[] isBot = new bool[3];
    public static GameObject[] players;

    void Awake()
    {
        players = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            players[i] = gameObject.transform.GetChild(i).gameObject;

        }
    }
    void Start()
    {
        for (int i = 1; i < 4; i++)
        {
            if (isBot[i-1])
            {
                Bot(i);
            }
            else
            {
                Human(i);
            }
        }
    }

    void Human(int index)
    {
        players[index].GetComponent<Bot>().enabled = false;
    }
    void Bot(int index)
    {
        players[index].GetComponent<Bot>().enabled = true;
    }

   
}
