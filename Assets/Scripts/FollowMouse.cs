using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private bool mustFollow;
    private float distanceFromCam;

    public void SetFollow()
    {
        distanceFromCam = transform.position.z;
        mustFollow = true;
    }
    public void StopFollow()
    {
        mustFollow = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(mustFollow)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceFromCam));
        }
    }
}
