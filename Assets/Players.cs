using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public static bool[] isHuman = new bool[4];
    public static GameObject[] players;
    // Start is called before the first frame update

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
            if (isHuman[i])
            {
                Human(i);
            }
            else
            {
                Bot(i);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
