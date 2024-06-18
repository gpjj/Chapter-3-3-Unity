using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody rb;
    private Vector3 movementDirection = Vector3.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        rb = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        controller.OnMoveEvent += Move;

    }

    private void Move(Vector3 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector3 direction)
    {
        direction = direction * 5;
        rb.velocity = direction;
    }
}
