using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float playerJumpForce;
    Rigidbody2D rb;
    float xInput;
    float yInput;
    bool isFacingRight;
    private bool isGrounded;
    public LayerMask layerMask;
    public Transform groundCheck;
    public float checkRadius;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, layerMask);
        xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * playerSpeed, rb.velocity.y);
        if (isFacingRight == false && xInput >0) 
        {
            Flip();
        }
        else if (isFacingRight == true && xInput < 0)
        {
            Flip();
        }
        if (Input.GetButtonDown("Fire1") && isGrounded==true)
        {
            rb.velocity = Vector2.up * playerJumpForce;
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0, 180, 0);
    }

    public void SuperJump()
    {
        rb.velocity = Vector2.up * playerJumpForce * 2f ;

    }
}
