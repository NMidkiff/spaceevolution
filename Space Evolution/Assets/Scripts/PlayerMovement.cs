using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    public float angularVelocity;

    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddForce(transform.up * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddForce(transform.up * -1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(transform.right * -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(transform.right);
        }

        if (Input.GetKey(KeyCode.E))
        {
            rb2d.angularVelocity = angularVelocity * -1;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            rb2d.angularVelocity = angularVelocity;
        }
    }
}
