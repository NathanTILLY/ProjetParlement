using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private bool mustFollow;
    private float distanceFromCam;
    public SnapGridManager sgm;
    public SnapGrid currentSnapGrid;
    
    public void SetFollow()
    {
        distanceFromCam = transform.position.z - Camera.main.transform.position.z;
        mustFollow = sgm.Activate();

        
    }
    public void StopFollow()
    {
      
        mustFollow = sgm.desActivate();

    }

    // Update is called once per frame
    void Update()
    {
        if(mustFollow && sgm.currentSnapGrid != null)
        {
            
            var mouseposition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceFromCam));
            Debug.Log(sgm.currentSnapGrid);
            var unSnappedPosition = new Vector3(mouseposition.x, mouseposition.y, mouseposition.z);
            transform.position = sgm.currentSnapGrid.transform.position;
            currentSnapGrid = sgm.currentSnapGrid;
            
        }
    }

}
