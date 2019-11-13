using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    private Rigidbody2D rigid;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {

            rigid.velocity = new Vector2(moveSpeed, rigid.velocity.y);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {

            rigid.velocity = new Vector2(-moveSpeed, rigid.velocity.y);
        }
    }
}
