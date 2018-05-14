﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHead : MonoBehaviour {

    public float rotationSpeed = 3.0f;

    [Range(-25, 25)]
    public float rotateX;
    [Range(-25, 25)]
    public float rotateY;
    [Range(-25, 25)]
    public float rotateZ;




    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime, Space.World);
    }



}
