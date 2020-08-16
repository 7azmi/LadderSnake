using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    
    void OnEnable()
    {
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().color = Board.whoesTurn.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
