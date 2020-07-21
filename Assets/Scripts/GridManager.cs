using UnityEngine;


public class GridManager : MonoBehaviour
{
    public GameObject[] Cells;
    int ChildrenCount;
    int rows = 10;
    int cols = 10;
    [SerializeField]
    int cellSize = 1;

    void Awake()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gridding()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (r % 2 == 0)
                {
                    float posX = c * cellSize - 4.5f;
                    float posY = r * cellSize - 4.5f;

                    Cells[int.Parse(r + c.ToString())].transform.position = new Vector2(posX, posY);
                }
                else
                {
                    float posX = 9-c * cellSize - 4.5f;
                    float posY = r * cellSize - 4.5f;

                    Cells[int.Parse(r + c.ToString())].transform.position = new Vector2(posX, posY);
                    
                }
                //float gridW = c;
                //float gridH = r;
                //transform.position = new Vector2(gridW / 2 + cellSize / 2, gridH / 2 + cellSize / 2);



            }
        }
    }

    [System.Obsolete]
    public void Activate()
    {
        Cells = new GameObject[100];
        ChildrenCount = transform.GetChildCount();
        Debug.Log(ChildrenCount); Debug.Log(ChildrenCount);

        for (int i = 0; i < ChildrenCount; i++)
        {
            Cells[i] = transform.GetChild(i).gameObject;
            Cells[i].name = (i + 1).ToString();
        }

        Gridding();
    }
}
