using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatDownStream : MonoBehaviour
{
    public float acceleration = 5;
    public float maxSpeed = 50;
    private Vector3 speed;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = new Vector3(-acceleration, 0, 0);
    }
    void Update()
    {
        if(rb.velocity.x > -maxSpeed)
            rb.AddForce(speed);
    }
}
