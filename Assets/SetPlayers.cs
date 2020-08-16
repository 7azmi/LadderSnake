using UnityEngine;

public class SetPlayers : MonoBehaviour
{

    void Start()
    {
        Manager.PN = 1;
    }

    public void AddPlayer()
    {
        Manager.PN++;
    }
    public void DelPlayer()
    {
        Manager.PN--;
    }

    public void Human(int index)
    {
        Players.isBot[index] = false;
    }
    public void Bot(int index)
    {
        Players.isBot[index] = true;
    }

   

    //public static void SetAsBot(int index)
    //{
    //    Players.isBot[index] = true;
    //}


}
