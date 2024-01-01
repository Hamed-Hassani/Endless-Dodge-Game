﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    SpriteRenderer sprite;
    public float xLimit;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FlipPlayer();
    }
    private void FixedUpdate()
    {

        float xInput = 0;
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                xInput = -1;

            }
            else
            {
                xInput = 1f;
            }
        }
        else
        {
            xInput = 0;
        }
        rb.AddForce(transform.right * speed * xInput);

    }
    void FlipPlayer()
    {
        if (rb.velocity.x < 0)
        {
            sprite.flipX = true;
        }
        else if (rb.velocity.x > 0)
        {
            sprite.flipX = false;
        }
    }
}
