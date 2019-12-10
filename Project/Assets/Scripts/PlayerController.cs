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
    private Animator anim;
    public GameObject touchScreen;
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_STANDALONE || UNITY
        touchScreen.SetActive(false);
#endif
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        //moveVelocity = 0f;
#if UNITY_STANDALONE || UNITY

        moveVelocity = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
           // rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
        }


        if(Input.GetKey(KeyCode.D))
        {
            //moveVelocity = moveSpeed;
            Move(1);
        }

        if(Input.GetKey(KeyCode.A))
        {
            Move(-1);
            // moveVelocity = -moveSpeed;
        }
#endif
        rigid.velocity = new Vector2(moveVelocity, rigid.velocity.y);

        if (rigid.velocity.x > 0)
            transform.localScale = new Vector3(1f,1f,1f);
        else if(rigid.velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);
    }

    public void Move(int moveInput)
    {
        moveVelocity = moveSpeed * moveInput;
    }
    public void Jump()
    {
        if (grounded)
        {
            Debug.Log("Jumping");
            rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
        }
    }
}
