using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Cell : MonoBehaviour
{
   
    [SerializeField]internal List<Player> settlers = new List<Player>();

    internal Vector2 cellSize { get; set; }
    internal Vector2 cellPosition { get; set; }

    [Sirenix.OdinInspector.Button]
    public void Create(Vector2 size, Vector2 pos, int index, Color color)
    {
        transform.localScale = size;

        transform.localPosition = pos;


        GetComponent<SpriteRenderer>().color = color;

        //number
        //GetComponentInChildren<TextMeshProUGUI>().text = index.ToString();

        cellSize = size;
        print(cellSize + "\n" + cellSize.magnitude);
        cellPosition = pos;
    }

    //int PlayerOriginalScale { get { return } }

    void Reposition(int cellPoints, Vector2[] poses)
    {
        
        Vector2 displacement = new Vector2((int)(cellSize.x / cellPoints), (int)(cellSize.y / cellPoints)) ;

        if (settlers.Count == 1) settlers[0].transform.localScale = settlers[0].originalSize; //what happens usually
        else
        {
            if ( Math.Sqrt((Mathf.Pow(settlers[settlers.Count-1].bounds.magnitude,2) * settlers.Count)) > cellSize.magnitude)//if bigger, you may do some changes to prevent none-integers
            {
                for (int i = 0; i < 16; i++)//to the next generation screens 2^16
                {
                    settlers[settlers.Count - 1].transform.localScale /= 2;
                    if (Math.Sqrt((Mathf.Pow(settlers[settlers.Count - 1].bounds.magnitude, 2) * settlers.Count)) < cellSize.magnitude) break;
                }
            }
            else if (Math.Sqrt((Mathf.Pow(settlers[settlers.Count - 1].bounds.magnitude*2, 2) * settlers.Count)) < cellSize.magnitude)//also if too small
            {
                for (int i = 0; i < 16; i++)
                {
                    settlers[settlers.Count - 1].transform.localScale *= 2;
                    if (Math.Sqrt((Mathf.Pow(settlers[settlers.Count - 1].bounds.magnitude * 2, 2) * settlers.Count)) > cellSize.magnitude) break;
                }
            }
            foreach (var s in settlers)
            {
                s.transform.localScale = settlers[settlers.Count - 1].transform.localScale;
            }
        }

        for (int i = 0; i < poses.Length; i++) // poses length is basically the same as settlers' count
        {
            settlers[i].transform.position = transform.position + (Vector3) (poses[i] * displacement);
        }
    }

    internal void Reposition()
    {

        switch (settlers.Count)
        {

            case 1:
                Reposition(0, new Vector2[] { new Vector2(0, 0) });
                break;
            case 2:
                Reposition(5, new Vector2[]
                {
                    new Vector2(-1,1),
                    new Vector2(1,-1)
                });
                break;
            case 3:
                Reposition(5, new Vector2[]
                {
                    new Vector2(-1,1),
                    new Vector2(0,0),
                    new Vector2(1,-1)
                });
                break;
            case 4:
                Reposition(5, new Vector2[]
                {
                    new Vector2(-1,1),
                    new Vector2(1,-1),
                    new Vector2(1,1),
                    new Vector2(-1,-1)
                });
                break;
            case 5:
                Reposition(5, new Vector2[]
               {
                    new Vector2(-1,1),
                    new Vector2(1,-1),
                    new Vector2(0,0),
                    new Vector2(1,1),
                    new Vector2(-1,-1)
               });
                break;
            case 6:
                Reposition(5, new Vector2[]
               {
                    new Vector2(1,1),
                    new Vector2(1,0),
                    new Vector2(1,-1),
                    new Vector2(-1,1),
                    new Vector2(-1,0),
                    new Vector2(-1,-1)
               });
                break;
            case 7:
                Reposition(5, new Vector2[]
               {
                    new Vector2(1,1),
                    new Vector2(1,0),
                    new Vector2(1,-1),
                    new Vector2(-1,1),
                    new Vector2(-1,0),
                    new Vector2(-1,-1),
                    new Vector2(0,0)
               });
                break;
            case 8:
                Reposition(5, new Vector2[]
               {
                    new Vector2(1,1),
                    new Vector2(1,0),
                    new Vector2(1,-1),
                    new Vector2(-1,1),
                    new Vector2(-1,0),
                    new Vector2(-1,-1),
                    new Vector2(0,1),
                    new Vector2(0,-1)
               });
                break;
            default:
                //:)
                break;
        }

        //if (settlers.Count == 1)
        //{
        //    settlers[0].transform.localScale = new Vector3(8, 8, 1);
        //    settlers[0].transform.position = transform.position;
        //}
        //else if (settlers.Count == 2)
        //{


        //    //            settlers[0].transform.position = transform.position + (new Vector2())
        //}
        //else if (settlers.Count == 3)
        //{

        //}
        //else if (settlers.Count == 4)
        //{

        //}
        //else if (settlers.Count == 5)
        //{

        //}
        //else if (settlers.Count == 6)
        //{

        //}
        //else if (settlers.Count == 7)
        //{

        //}
        //else if (settlers.Count == 8)
        //{

        //}
    }
}
