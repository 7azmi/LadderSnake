using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class Movement : MonoBehaviour
{
    public float moveSpeed
    {
        get { return Manager.gameSpeed *3; }
        set { moveSpeed = value ; }
    }
    public int pos = 0;
    public int distance;
    


    private bool gameOver;
    internal bool rollAgain;
    public GameObject WinnerWindow;
    public string Rule;

    void Awake()
    {
        gameOver = false;
        pos = -1;
    }

    void Start()
    {
        //moveSpeed = 7;
    }

    void FixedUpdate()
    {


        if (Manager.whoesTurn == gameObject)
        {
            if (distance != 0)
            {
                if (pos + distance > 99)
                {
                    distance = 0;
                    if (Dice.dice != 6) Manager.Next();
                    Dice.btn.interactable = true;
                }
                else
                {
                    Move(Manager.ways[pos + 1].transform);

                    if (SamePosition(pos + 1))
                    {
                        distance--;
                        pos++;
                        SoundManager.Play("btn");
                        //for Special Positions (and or) change Player I like typing  
                        if (distance == 0) Action();
                    }
                }

            }

        }

    }

    private void Action()
    {
        Move();
        if (!gameOver)
        {
            if (Dice.dice != 6) Manager.Next();
            Dice.btn.interactable = true;
        }
        
        
    }

    void Move(int target)
    {
        do
        {
            transform.position = Vector3.MoveTowards(transform.position, Manager.ways[target].transform.position, moveSpeed * Time.deltaTime);
        } while (transform.position != Manager.ways[target].transform.position);
        pos = target;


    }

    bool Move(Transform target)
    {
        if(transform.position!= target.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            return true;
        }
        return false;
    }

    bool SamePosition(int targetIndex)
    {

        if (transform.position == Manager.ways[targetIndex].position) return true;
        return false;
    }

    public void Move()
    {
        //change source later
        foreach (Vector2 i in GameObject.FindGameObjectWithTag("Board").GetComponent<Board>().Snakes)
        {
            if ((i.x-1) == pos)
            {
                Move((int)(i.y-1));
                SoundManager.Play("btn");
                break;
            }
        }
        foreach (Vector2 i in GameObject.FindGameObjectWithTag("Board").GetComponent<Board>().Ladders)
        {
            if ((i.x-1) == pos)
            {
                Move((int)(i.y-1));
                SoundManager.Play("btn");
                break;
            }
        }

        if (pos == 99) 
        {
            SoundManager.Play("win");
            AdsManager.ShowAd();
            Winner();
        }    
        #region delete
        //switch (pos)
        //{
        //    //Ladders
        //    case 8:
        //        Move(29); SoundManager.Play("btn");

        //        break;
        //    case 15:
        //        Move(24); SoundManager.Play("btn");
        //        break;
        //    case 20:
        //        Move(39); SoundManager.Play("btn");
        //        break;
        //    case 28:
        //        Move(72); SoundManager.Play("btn");
        //        break;
        //    case 36:
        //        Move(64); SoundManager.Play("btn");
        //        break;
        //    case 60:
        //        Move(78); SoundManager.Play("btn");
        //        break;
        //    case 70:
        //        Move(90); SoundManager.Play("btn");
        //        break;
        //    case 82:
        //        Move(98); SoundManager.Play("btn");
        //        break;
        //    case 86:
        //        Move(92); SoundManager.Play("btn");
        //        break;

        //    //Snakes
        //    case 97:
        //        Move(76); SoundManager.Play("btn");
        //        break;
        //    case 94:
        //        Move(84); SoundManager.Play("btn");
        //        break;
        //    case 91:
        //        Move(69); SoundManager.Play("btn");
        //        break;
        //    case 81:
        //        Move(79); SoundManager.Play("btn");
        //        break;
        //    case 73:
        //        Move(26); SoundManager.Play("btn");
        //        break;
        //    case 61:
        //        Move(42); SoundManager.Play("btn");
        //        break;
        //    case 50:
        //        Move(31); SoundManager.Play("btn");
        //        break;
        //    case 34:
        //        Move(6); SoundManager.Play("btn");
        //        break;
        //    case 23:
        //        Move(1); SoundManager.Play("btn");
        //        break;
        //   //winning
        //    case 99:
        //        SoundManager.Play("win");
        //        AdsManager.ShowAd();
        //        Winner();
        //        break;



        //}
        #endregion


    }

    private void Winner()
    {
        WinnerWindow.SetActive(true);
        gameOver = true;
             
    }
}
