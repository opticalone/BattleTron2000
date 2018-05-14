﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 10f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 4f;
    private float sensitivityY = 4f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;

    }
}
