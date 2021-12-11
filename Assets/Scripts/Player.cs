using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;

public class Player : MonoBehaviour
{

    internal SpriteRenderer rend;

    [ColorPalette]
    public Color ColorPallete;

    internal Vector2 originalSize;

    internal Vector2 bounds { get { return rend.bounds.size; } }//x or y

    [ShowInInspector, ReadOnly] public static List<Player> AllPlayers;


    public static Player WhoseTurn { get {return AllPlayers[WhoseTurnIndex]; } }
    public static int WhoseTurnIndex = 0;// to not having to search for the player in list

    Cell[] Cells { get { return GridGenerator.Cells; } }

    //float PlayerSize

    int PlayerPosition { get; set; }
    int CellsCount { get { return GridGenerator.Cells.Length; } }

    private void Awake()
    {
        AddMe();

        rend = GetComponent<SpriteRenderer>();
        rend.color = ColorPallete;
    }

    private void Start()
    {
        originalSize = Vector2.one;
        transform.localScale = originalSize;

        for (int i = (int)transform.localScale.magnitude; i < Cells[0].cellSize.magnitude; i++)//if cell size is smaller than player's, we're fucked
        {
            //print("hi");
            if ((2 * bounds.magnitude) > Cells[0].cellSize.magnitude) break;
            originalSize *= 2;
            transform.localScale = originalSize;
        }
        //print(GridGenerator.Cells[1].cellSize.magnitude);
        //print(transform.localScale.magnitude);

        PlayerPosition = 0;

        MyTurn += () =>
         {
             rend.material.SetFloat("_OutlineAlpha", 1);
         };
    }

    void AddMe()
    {
        if (AllPlayers == null) AllPlayers = new List<Player>();
        AllPlayers.Add(this);
    }

    [Range(.01f,0.5f), SerializeField]
    float stepDelay = .1f;

    IEnumerator MoveCoroutine(int steps)
    {
        if (PlayerPosition + steps <= CellsCount)
        {
            for (int i = 0; i < steps; i++)
            {
                yield return new WaitForSeconds(stepDelay);
                StepForward();
            }
        }

        if (PlayerPosition == CellsCount) print("yaaay!");
        else NextPlayer();
    }

    internal void Move(int steps) => StartCoroutine(MoveCoroutine(steps));

    internal Action MyTurn { get; set; }

    private void NextPlayer()
    {
        if (WhoseTurnIndex != AllPlayers.Count - 1) WhoseTurnIndex++;
        else WhoseTurnIndex = 0;

        rend.material.SetFloat("_OutlineAlpha", 0);

        WhoseTurn.MyTurn?.Invoke();
    }

    
    internal void StepForward()
    {
        Cells[PlayerPosition].settlers.Remove(this);

        PlayerPosition++;

        Cells[PlayerPosition].settlers.Add(this);
        
        Cells[PlayerPosition].Reposition();//long story 
    }

}
