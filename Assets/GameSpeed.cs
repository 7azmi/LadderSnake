using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSpeed : MonoBehaviour
{
    public TextMeshProUGUI GS;
    public void ChangeSpeed()
    {
        if (Manager.gameSpeed < 4)
        {
            Manager.gameSpeed *= 2;
            GS.text = (Manager.gameSpeed) + "x";
        }
        else
        {
            Manager.gameSpeed =0.5f;
            GS.text = "1/2x";
        }
    }
}
