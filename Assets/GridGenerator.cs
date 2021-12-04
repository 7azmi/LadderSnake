using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;

public class GridGenerator : MonoBehaviour
{
    public GameObject cellPrefab;
    public Cell[] Cells;


    private void Start()
    {
        Cells = CreateGrid();
    }

    Cell[] CreateGrid()
    {
        List<Cell> cells = new List<Cell>();

        float width = Screen.width;
        float height = Screen.height;

        int cellSize = CellSize(width, height);
        int thickness = 4;

        int rows = 10;

        bool RTL = false;

        int cellCounter = 0;

        //vertical
        for (int j = (int) height - cellSize * rows ; j < height; j+= cellSize)
        {
            float cellY = j - (height / 2) + cellSize / 2;
            
            //horizontal
            for (int i = 0; i < width; i += cellSize)
            {
                cellCounter++;

                float cellX;
                if (RTL) cellX = (width - i) - (width / 2) - cellSize / 2;
                else cellX = i - (width / 2) + cellSize / 2; 
                GameObject cell = CreateCell(new Vector2(cellSize, cellSize), thickness, cellCounter);
                cell.transform.localPosition = new Vector3(cellX, cellY, 0);

                cells.Add(cell.GetComponent<Cell>());
            }
            RTL = !RTL;
        }

        return cells.ToArray();

    }


    //screen lab
    private int CellSize(float width, float height)
    {
        for (int i = 10; i > 0; i--)
        {
            if (width % i == 0) return (int) width / i;
        }
        
        return 1; //won't happen mostly
    }

    GameObject CreateCell(Vector2 size, float thickness, int index)
    {
        var cell = Instantiate(cellPrefab, transform);
        cell.GetComponent<Cell>().Create(size, thickness, index);
        return cell;
    }
}
