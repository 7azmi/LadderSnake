using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSpeed : MonoBehaviour
{
    public TextMeshProUGUI GS;
    public void ChangeSpeed()
    {
        if (Board.gameSpeed < 4)
        {
            Board.gameSpeed *= 2;
            GS.text = (Board.gameSpeed) + "x";
        }
        else
        {
            Board.gameSpeed =0.5f;
            GS.text = "1/2x";
        }
    }
}
