using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapGrid : MonoBehaviour
{
    public SnapGridManager snapgridmanager;
    public FollowMouse expectedPiece;
    private void OnMouseEnter()
    {
        snapgridmanager.currentSnapGrid = this;

    }

    private void OnMouseExit()
    {
        snapgridmanager.currentSnapGrid = null;
    }
}
