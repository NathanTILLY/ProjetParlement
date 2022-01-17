using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapGrid : MonoBehaviour
{
    public SnapGridManager snapgridmanager;
    public FollowMouse expectedPiece, currentPiece;

    private void OnMouseEnter()
    {
        snapgridmanager.currentSnapGrid = this;

    }

    private void OnMouseExit()
    {
        snapgridmanager.currentSnapGrid = null;
    }

    public bool IsValid()
    {
        return currentPiece == expectedPiece;
    }
}
