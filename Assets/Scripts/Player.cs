using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;

public class Player : MonoBehaviour
{
    [ColorPalette]
    public Color ColorPallete;

    [ShowInInspector, ReadOnly] public static List<Player> AllPlayers;

    public static Player WhoseTurn { get {return AllPlayers[WhoseTurnIndex]; } }
    public static int WhoseTurnIndex = 0;// to not having to search for the player in list

    Cell[] Cells { get { return GridGenerator.Cells; } }

    int PlayerPosition { get; set; }
    int CellsCount { get { return GridGenerator.Cells.Length; } }

    private void Awake()
    {
        AddMe();

        GetComponent<SpriteRenderer>().color = ColorPallete;
    }

    private void Start()
    {
        PlayerPosition = 0;
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

    Action MyTurn { get; set; }

    private void NextPlayer()
    {
        if (WhoseTurnIndex != AllPlayers.Count - 1) WhoseTurnIndex++;
        else WhoseTurnIndex = 0;

        MyTurn?.Invoke();
    }

    
    internal void StepForward()
    {
        Cells[PlayerPosition].settlers.Remove(this);

        PlayerPosition++;

        Cells[PlayerPosition].settlers.Add(this);

        Cells[PlayerPosition].Reposition(this);//long story
    }

}
