using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAdvanturerKnight : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public Rigidbody2D rb;
    public float normalMovementSpeed;
    private float horizontalMove = 0f;
    private bool crouch = false;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool isJumping;
    public float jumpForce;

    private float jumpTimeCounter;
    public float jumpTime;

    public ParticleSystem dust;
    private readonly float boostTime = 3f;
    SpriteRenderer spriteColor;

    public Joystick joystick;
    void Start()
    {
        spriteColor = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (normalMovementSpeed >= 800f)
        {
            //Decrease boosting speed and color
            spriteColor.color = new Color(0, 255, 15, 255);
            StartCoroutine(DecreaseSpeed());
        }
        if (jumpForce > 400f)
        {
            //Decreasejump force and color
            spriteColor.color = new Color(255, 0, 0, 255);
            StartCoroutine(DecreaseJumpForce());
        }
        if (rb.gravityScale <= 20f)
        {
            //Decrease gravity and color
            spriteColor.color = new Color(255, 246, 0, 255);
            StartCoroutine(ResetGravity());
        }

        if (joystick.Horizontal >= 0.2f)
        {
            horizontalMove = normalMovementSpeed;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            horizontalMove = -normalMovementSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }
        float verticalMove = joystick.Vertical;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && verticalMove >= .5f)
        {
            FindObjectOfType<AudioManager>().Play("Jump");
            animator.SetTrigger("takeOf");
            isJumping = true;
            rb.velocity = Vector2.up * jumpForce;
            CreateDust();
        }
        if (isGrounded == true)
        {
            animator.SetBool("IsJumping", false);
        }
        else
        {
            animator.SetBool("IsJumping", true);
        }

        if (verticalMove >= .5f && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        if (verticalMove >= .5f)
        {
            isJumping = false;
            CreateDust();
        }
        if (verticalMove <= -0.5f)
        {
            crouch = true;
        }
        else
        {
            crouch = false;
        }
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, isJumping);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Moving_Platform"))
            this.transform.parent = col.transform;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Moving_Platform"))
            this.transform.parent = null;
    }
    void CreateDust()
    {
        dust.Play();
    }
    IEnumerator DecreaseSpeed()
    {
        yield return new WaitForSeconds(boostTime);
        spriteColor.color = new Color(255, 255, 255, 255);
        normalMovementSpeed = 400f;
    }
    IEnumerator DecreaseJumpForce()
    {
        yield return new WaitForSeconds(boostTime);
        spriteColor.color = new Color(255, 255, 255, 255);
        jumpForce = 235f;
    }
    IEnumerator ResetGravity()
    {
        yield return new WaitForSeconds(boostTime);
        spriteColor.color = new Color(255, 255, 255, 255);
        rb.gravityScale = 40f;
    }
}