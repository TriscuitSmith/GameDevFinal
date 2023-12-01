using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTurret : MonoBehaviour
{
    /*
    public static placeTurret current;

    public Gridlayout gridlayout;
    private Grid grid;
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private Tilebase tilebase;

    public GameObject turretTesla;


    private void MouseClick()
    {

    }

    private void Awake()
    {
        current - this;
        grid = gridlayout.gameObject.SetComponent<Grid>();
    }

    public static Vector3 GetMousePos()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            return raycastHit.point;
        }
        else
        {
            return Vector3.zero;
        }
    }

    public Vector3 snapPoistion(Vector3 pos)
    {
        Vector3Int cellPos = gridlayout.WorldToCell(pos);
        pos = grid.GetCellCenterWorld(cellPos);
        return pos;
    }
    */
}
