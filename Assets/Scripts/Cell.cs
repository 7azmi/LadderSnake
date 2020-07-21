using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[ExecuteInEditMode]
public class Cell : MonoBehaviour
{
    public Color CellColor;
    public TextMeshPro Number;
    // Start is called before the first frame update
    void Start()
    {
        if (int.Parse(name) % 2 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = CellColor;
        } 
        Number.text = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
