using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;

public class GridGenerator : MonoBehaviour
{
    public GameObject cellPrefab;
    [ShowInInspector, ReadOnly]public static Cell[] Cells;

    [SerializeField, ColorPalette] Color color1;
    [SerializeField, ColorPalette] Color color2;

    private void Awake()
    {
        Cells = CreateGrid();
    }

    Cell[] CreateGrid()
    {
        List<Cell> cells = new List<Cell>();

        float width = Screen.width;
        float height = Screen.height;

        Vector2 cellSize = CellSize(width, height);

        int cellSizeX = (int)cellSize.x;
        int cellSizeY = (int)cellSize.y;

        int rows = 10;
        int column = 10;

        bool RTL = false;
        bool isColor1 = false;

        int cellCounter = 0;

        //vertical
        for (int j = (int)(height - cellSizeY * rows); j < height; j+= cellSizeY)
        {
            float cellPosY = j - (height / 2) + cellSizeY / 2;
            
            //horizontal
            for (int i = 0; i < width; i += cellSizeX)
            {
                cellCounter++;

                float cellPosX;
                if (RTL) cellPosX = (width - i) - (width / 2) - cellSizeX / 2;
                else cellPosX = i - (width / 2) + cellSizeX / 2;

                Color cellColor = isColor1 ? color1 : color2;
                isColor1 = !isColor1;

                GameObject cell = CreateCell(new Vector2(cellSizeX, cellSizeY), new Vector2(cellPosX, cellPosY), cellCounter, cellColor);
                //cell.transform.localPosition = new Vector3(cellPosX, cellPosY, 0);

                Cell cellComponent = cell.GetComponent<Cell>();

                //cellComponent.cellPosition = new Vector2(cellPosX, cellPosY);
                //cellComponent.cellSize = new Vector2(cellSize, cellSize);

                cells.Add(cellComponent);
            }
            RTL = !RTL;
        }

        return cells.ToArray();

    }


    //screen lab
    private Vector2 CellSize(float width, float height)
    {
        for (int i = 10; i > 0; i--)
        {
            if (width % i == 0) return new Vector2((int) width / i, (int)width / i) ;
        }

        return Vector2.one; //won't happen mostly
    }

    GameObject CreateCell(Vector2 size, Vector2 pos, int index, Color color)
    {
        var cell = Instantiate(cellPrefab, transform);
        cell.GetComponent<Cell>().Create(size, pos, index, color);
        return cell;
    }
}
