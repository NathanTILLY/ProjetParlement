using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapGridManager : MonoBehaviour
{
    public SnapGrid currentSnapGrid;
    public SnapGrid[] snapGrids;

    
    public bool Activate()
    {
        foreach (var snapGrid in snapGrids)
        {
            snapGrid.gameObject.SetActive(true);
        }
        return true;
    }
    public bool desActivate()
    {
        foreach (var snapGrid in snapGrids)
        {
            snapGrid.gameObject.SetActive(false);
        }
        return false;
    }
}
