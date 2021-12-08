using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class Manager : MonoBehaviour
{
    [ColorPalette]
    public Color ColorPallete;


    private void Start()
    {
        Player.WhoseTurnIndex = 0;


    }
    //public static int PN;
    //public static Board_Card Board_Card;



}
