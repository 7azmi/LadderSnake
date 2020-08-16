using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static int PN;
    public static Board_Card Board_Card;

    //temp
    public bool locked;
 

    void Awake()
    {
        
    }

    public void temp()
    {
        locked = Board_Card.Locked;
    }







}
