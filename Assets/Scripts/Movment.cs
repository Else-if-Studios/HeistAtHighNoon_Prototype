using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody2D body;
    Transform transform;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;
    public float dogeSpeed = 500f;

    private bool doDoge = false;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            doDoge = true;
        }
    }

    private void FixedUpdate()
    {
        if (doDoge)
        {
            body.velocity = new Vector2(horizontal * dogeSpeed, vertical * dogeSpeed);
            doDoge = false;
        }
        else
        {
            body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        }
        

    }
}
