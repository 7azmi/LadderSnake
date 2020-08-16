using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Board",menuName = "Board")]
public class Board_Card : ScriptableObject
{
    public Sprite Board;

    [SerializeField]
    internal bool Locked;

    public level boardLevel;

    [HideInInspector]
    public enum level
    {
        Easy =0,
        Normal =1,
        Hard =2,

    }

    public Vector2[] ladders;
    public Vector2[] snakes;

}
