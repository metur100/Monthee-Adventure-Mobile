using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNinjaNum : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public GameObject gameOverUI;
    public Rigidbody2D rb;
    public float normalMovementSpeed = 200f;
    private float slowedMovementSpeed = 50f;
    private float trapMoveSpeed = 0f;
    private float maxMovementSpeed = 200f;
    private float horizontalMove = 0f;
    private float trapOverTimeDuration = 3f;
    private float slowOverTimeDuration = 1f;
    private bool jump = false;
    private bool crouch = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal2") * normalMovementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump2"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            FindObjectOfType<AudioManager>().Play("JumpDragon");
        }
        if (Input.GetButtonDown("Crouch2"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch2"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

        if (rb.position.y < -80f)
        {
            gameOverUI.SetActive(true);
        }
    }
    public void CoroutineMoveIfTrapNinja()
    {
        StartCoroutine(stopMoveIfTrapNinja());
    }
    public void CoroutineNinjaSlowOverTimeFrost()
    {
        StartCoroutine(SlowOverTimeOnHitWithFrostBullet());
    }
    IEnumerator stopMoveIfTrapNinja()
    {
        normalMovementSpeed = trapMoveSpeed;
        yield return new WaitForSeconds(trapOverTimeDuration);
        normalMovementSpeed = maxMovementSpeed;
    }
    IEnumerator SlowOverTimeOnHitWithFrostBullet()
    {
        normalMovementSpeed = slowedMovementSpeed;
        yield return new WaitForSeconds(slowOverTimeDuration);
        normalMovementSpeed = maxMovementSpeed;
    }
}
