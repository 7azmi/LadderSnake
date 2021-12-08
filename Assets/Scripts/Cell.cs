using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteInEditMode]
public class Cell : MonoBehaviour
{
    //lines, or $250.000 code
    [SerializeField] GameObject up;
    [SerializeField] GameObject down;
    [SerializeField] GameObject left;
    [SerializeField] GameObject right;
                              //X 
                              //X
                              //L1
                              //R1

    
    internal List<Player> settlers = new List<Player>();

    [Sirenix.OdinInspector.Button]
    public void Create(Vector2 size, float thickness, int index)
    {
        //size && thickness
        up.transform.localScale = new Vector3(size.x - thickness*2, thickness, 0); 
        down.transform.localScale = new Vector3(size.x - thickness*2, thickness, 0);
        left.transform.localScale = new Vector3(thickness, size.y - thickness * 2, 0);
        right.transform.localScale = new Vector3(thickness, size.y - thickness * 2, 0);

        //spacing
        up.transform.localPosition = new Vector3(0, size.y / 2, 0);
        down.transform.localPosition = new Vector3(0, -size.y / 2, 0);
        left.transform.localPosition = new Vector3(-size.x / 2, 0, 0);
        right.transform.localPosition = new Vector3(size.x / 2, 0, 0);

        //number
        GetComponentInChildren<TextMeshProUGUI>().text = index.ToString();
        //RectTransform rect = GetComponent<Canvas>().GetComponent<RectTransform>();
        //RectTransform rectTransform = new RectTransform();


    }

    internal void Reposition(Player WhoIsMoving)
    {
        
    }
}
