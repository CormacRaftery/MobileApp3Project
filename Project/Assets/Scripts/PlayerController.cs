using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveVelocity;
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
        moveVelocity = 0f;
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
        }


        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = moveSpeed;
        }

        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -moveSpeed;
        }
        rigid.velocity = new Vector2(moveVelocity, rigid.velocity.y);

        if (rigid.velocity.x > 0)
            transform.localScale = new Vector3(1f,1f,1f);
        else if(rigid.velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);
    }
}
