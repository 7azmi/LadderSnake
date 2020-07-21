using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Manager.PN = 1;   
    }


    public void Human(int index)
    {
        Players.isHuman[index] = true;
    }
    public void Bot(int index)
    {
        Players.isHuman[index] = false;
    }


    public void AddPlayer()
    {
        Manager.PN++;
    }
    public void DelPlayer()
    {
        Manager.PN--;
    }

    public void Play()
    {
        SceneManager.LoadScene("The Game");
    }
}
