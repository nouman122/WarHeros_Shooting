﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followTransform.position.x, 235.7275f, -142.87f);


    }
}

