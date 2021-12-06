using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwipe : MonoBehaviour
{

    float t;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        t += Input.GetAxis("Mouse ScrollWheel");
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.up), Quaternion.Euler(Vector3.up * 180), t);
      
    }

  
}
