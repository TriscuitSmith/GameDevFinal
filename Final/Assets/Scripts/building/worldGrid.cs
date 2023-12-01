using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldGrid
{
    private int x;
    private int z;
    private int[,] gridCells;
    //private bool emptySpot;
    private int cellSize;

    public worldGrid()
    {
        this.x = 5;
        this.z = 5;
        this.gridCells = new int[x, z];
        //this.emptySpot = false;
        this.cellSize = 1;

        for (int i = 0; i < gridCells.GetLength(0); i++)
        {
            for (int j = 0; j < gridCells.GetLength(1); j++)
            {
                Debug.DrawLine(GetGridPosition(i,j), GetGridPosition(i,j+1), Color.white, 100f);
                Debug.DrawLine(GetGridPosition(i,j), GetGridPosition(i+1,j), Color.white, 100f);
            }
        }
    }

    private Vector3 GetGridPosition(int i, int j)
    {
        return new Vector3(i,0,j) * cellSize;
    }
}
