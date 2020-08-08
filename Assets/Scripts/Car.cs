using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;
    public float turnSpeed;
    private float currentSpeed;
    public bool shouldAccelerate;
    private Rigidbody rig;

    // instance
    public static Car instance;
    void Awake()
    {
        instance = this;
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (shouldAccelerate)
        {
            currentSpeed = Mathf.Clamp(currentSpeed + (Time.deltaTime * acceleration), 0.0f, maxSpeed);
        }
        else
        {
            currentSpeed = Mathf.Clamp(currentSpeed - (Time.deltaTime * acceleration), 0.0f, maxSpeed);
        }
        rig.velocity = transform.forward * currentSpeed;
    }

    public enum Direction
    {
        Left = -1, Right = 1
    }

    public void Turn(Direction direction)
    {
        transform.Rotate(Vector3.up, (float)direction * turnSpeed * Time.deltaTime);
    }
}
