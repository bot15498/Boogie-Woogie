﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform followTarget;
    public float smoothspeed;
    private Vector3 playerxpos;

	void Start()
    {
        followTarget = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        playerxpos = new Vector3(followTarget.position.x, followTarget.position.y, 0);

        Vector3 desiredposition = playerxpos + offset;
        Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition, smoothspeed * Time.deltaTime);
        transform.position = smoothedposition;
    }
}
