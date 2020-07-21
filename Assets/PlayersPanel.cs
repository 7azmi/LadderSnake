using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersPanel : MonoBehaviour
{

    public GameObject whoesTurn;
    public GameObject[] players = new GameObject[4];
    public GameObject[] bots = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < Manager.players.Count; i++)
        {
            players[i].SetActive(true);
            if (!Players.isHuman[i] && i != 0) bots[i - 1].SetActive(true);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Manager.players.Count; i++)
        {
            if (Manager.whoesTurn == Manager.players[i])
            {
                whoesTurn.transform.position = players[i].transform.position;
            }
        }
        
    }
}
