using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMovement : MonoBehaviour
{
    public List<Vector3> floorPosition = new List<Vector3>();
    public Camera Second;
    //public GameObject firstCamera;

    void Start()
    {
        //GetComponent<Camera>().enabled = true;
    }

    void Update()
    {
        if (GameObject.Find("Main Camera") == null)
        {
            Second.enabled = true;
        }
    }
}