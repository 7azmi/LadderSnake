using UnityEngine;

public class Movement : MonoBehaviour
{
    //public float moveSpeed
    //{
    //    get { return Board.gameSpeed *3; }
    //    set { moveSpeed = value ; }
    //}
    //public int pos = 0;
    //public int distance;
    

    //private bool gameOver;
    //internal bool rollAgain;
    //public GameObject WinnerWindow;
    //public string Rule;

    //void Awake()
    //{
    //    gameOver = false;
    //    pos = -1;
        
        
    //}

    //void Start()
    //{

    //}

    //void FixedUpdate()
    //{


    //    if (Board.whoesTurn == gameObject)
    //    {
    //        if (distance != 0)
    //        {
    //            if (pos + distance > 99)
    //            {
    //                //choose move Back or don't move when dice_number > 100
    //                Move("Go back"); //Manager.ToFinish



    //            }
    //            else
    //            {
    //                StepForward();
    //            }

    //        }

    //    }

    //}

    //private void StepForward()
    //{
    //    Move(Board.ways[pos + 1].transform);

    //    if (SamePosition(pos + 1))
    //    {
    //        distance--;
    //        pos++;
    //        AudioManager.instance.Play("step");
    //        //for Special Positions (and or) change Player I like typing  
    //        if (distance == 0) Action();
    //    }
    //}

    //private void GoBack()
    //{

    //    if(Move(Board.ways[99 - distance].transform))
    //    {
    //        //none
    //    }
    //    else
    //    {
    //        pos = 99 - distance;
    //        distance = 0;
    //        Action();
    //    }
    //}

    //private void Move(string rule)
    //{
    //    switch (rule)
    //    {

    //        case "Do not move":
    //            //rule 1 Do not move"
    //            distance = 0;
    //            if (Dice.dice != 6) Invoke("NextPlayer", 1 - (Board.gameSpeed * .25f));
    //            else Dice.btn.interactable = true;
    //            break;

    //        case "Go back":
    //            //rule 2
    //            if (pos == 99) GoBack();
    //            else StepForward();
    //            break;
    //    }
        
    //}

    //private void Action()
    //{
    //    Move();
    //    if (!gameOver)
    //    {
    //        if (Dice.dice != 6) Invoke("NextPlayer", 1 - (Board.gameSpeed * .25f));
    //        else Dice.btn.interactable = true;
    //        //if (Dice.dice != 6) Board.Next();
    //        //Dice.btn.interactable = true;
    //    }
        
        
    //}

    //void Move(int target)
    //{
    //    do
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, Board.ways[target].transform.position, moveSpeed * Time.deltaTime);
    //    } while (transform.position != Board.ways[target].transform.position);
    //    pos = target;


    //}

    //bool Move(Transform target)
    //{
    //    if(transform.position != target.position)
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    //        return true;
    //    }
    //    return false;
    //}

    //bool SamePosition(int targetIndex)
    //{

    //    if (transform.position == Board.ways[targetIndex].position) return true;
    //    return false;
    //}

    //public void Move()
    //{
    //    //change source later
    //    foreach (Vector2 i in Manager.Board_Card.snakes )
    //    {
    //        if ((i.x - 1) == pos)
    //        {
    //            Move((int)(i.y - 1));
    //            AudioManager.instance.Play("snake");
    //            break;
    //        }
    //    }
    //    foreach (Vector2 i in Manager.Board_Card.ladders)
    //    {
    //        if ((i.x-1) == pos)
    //        {
    //            Move((int)(i.y-1));
    //            AudioManager.instance.Play("ladder");
    //            break;
    //        }
    //    }

    //    if (pos == 99) 
    //    {
    //        AudioManager.instance.Play("win");
    //        AdsManager.ShowAd();
    //        Winner();
    //    }  


    //}

    //private void NextPlayer()
    //{
    //    Board.Next();
    //    Dice.btn.interactable = true;
    //}

    //private void Winner()
    //{
    //    WinnerWindow.SetActive(true);
    //    gameOver = true;
             
    //}
}
