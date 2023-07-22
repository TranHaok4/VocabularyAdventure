using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : HaroMonobehavior
{
    [SerializeField] protected float speed = 5.0f;
    [SerializeField] protected float jumpForce = 5.0f;
    [SerializeField] protected bool isJumping = false;
    private Rigidbody2D rb;
    private Animator animator;
    [SerializeField] protected SpriteRenderer sr;
    [SerializeField] protected PlayerCtrl playerCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPlayerCtrl();
        rb = GetComponent<Rigidbody2D>();
        animator = transform.GetComponent<Animator>();
    }
    protected override void Start()
    {
        sr = playerCtrl.Model;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if(moveHorizontal!=0)
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsMoving", false);


        }
        // Flip the sprite based on the direction of movement
        if (moveHorizontal > 0 && sr.flipX)
        {
            sr.flipX = false;
        }
        else if (moveHorizontal < 0 && !sr.flipX)
        {
            sr.flipX = true;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       // if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            animator.SetBool("IsJumping", false);

        }
    }
    protected void LoadPlayerCtrl()
    {
        if (playerCtrl != null) return;
        playerCtrl = transform.GetComponent<PlayerCtrl>();
    }
}