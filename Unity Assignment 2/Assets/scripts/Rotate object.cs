﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateobject : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);

    }
public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
