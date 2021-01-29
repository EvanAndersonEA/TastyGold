using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 speed = new Vector3(-10, 0, 0);
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(rb.velocity.x > -500f)
            rb.AddForce(speed);
    }
}
