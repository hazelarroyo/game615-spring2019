﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        transform.position = new Vector3(transform.position.x + 0.01f, 
        transform.position.y, transform.position.z);
    }

}