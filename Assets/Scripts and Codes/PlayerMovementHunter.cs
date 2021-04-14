using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHunter : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public GameObject gameOverUI;
    public Rigidbody2D rb;
    public float normalMovementSpeed = 200f;
    private float slowedMovementSpeed = 50f;
    private float maxMovementSpeed = 200f;
    private float horizontalMove = 0f;
    private float trapMovementSpeed = 0f;
    private float trapOverTimeDuration = 3f;
    private float slowOverTimeDuration = 1f;
    private bool jump = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * normalMovementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            FindObjectOfType<AudioManager>().Play("JumpHunter");
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

        if (rb.position.y < -80f)
        {
            gameOverUI.SetActive(true);
        }
    }
    public void CoroutineHunterSlowOverTimeFrost()
    {
        StartCoroutine(SlowOverTimeOnHitWithFrostBullet());
    }
    public void CoroutineMoveIfTrapHunter()
    {
        StartCoroutine(stopMoveIfTrapHunter());
    }
    IEnumerator SlowOverTimeOnHitWithFrostBullet()
    {
        normalMovementSpeed = slowedMovementSpeed;
        yield return new WaitForSeconds(slowOverTimeDuration);
        normalMovementSpeed = maxMovementSpeed;
    }
    IEnumerator stopMoveIfTrapHunter()
    {
        normalMovementSpeed = trapMovementSpeed;
        yield return new WaitForSeconds(trapOverTimeDuration);
        normalMovementSpeed = maxMovementSpeed;
    }
}
