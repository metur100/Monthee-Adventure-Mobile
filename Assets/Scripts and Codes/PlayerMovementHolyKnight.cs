using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementHolyKnight : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public GameObject gameOverUI;
    public Rigidbody2D rb;
    public Image speeding;
    public float normalMovementSpeed = 200f;
    private float slowedMovementSpeed = 50f;
    private float maxMovementSpeed = 200f;
    private float incraseMovementSpeed = 300f;
    private float horizontalMove = 0f;
    private float slowOverTimeDuration = 2f;
    private float speedOverTimeDuration = 3f;
    private float speedingCd = 9f;
    private float trapOverTimeDuration = 3f;
    private float trapMovementSpeed = 0f;
    private bool jump = false;
    private bool isSpeeding = false;
    private bool isSpeedingCd = false;

    private void Start()
    {
        speeding.fillAmount = 0;
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * normalMovementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            FindObjectOfType<AudioManager>().Play("JumpHolyKnight");
        }
        if (Input.GetKeyDown(KeyCode.E) && isSpeedingCd == false)
        {
            isSpeedingCd = true;
            speeding.fillAmount = 1;
            FindObjectOfType<AudioManager>().Play("SprintHolyKnight");
            StartCoroutine(IncreasedMovementSpeed());
        }
        if (isSpeedingCd)
        {
            speeding.fillAmount -= 1 / speedingCd * Time.deltaTime;
            if (speeding.fillAmount <= 0)
            {
                speeding.fillAmount = 0;
                isSpeedingCd = false;
            }
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
    public void CoroutineHolyKnightSlowOverTimeFrost()
    {
        StartCoroutine(SlowOverTimeOnHitWithFrostBullet());
    }
    public void CoroutineMoveIfTrapHolyKnight()
    {
        StartCoroutine(stopMoveIfTrapHolyKnight());
    }
    IEnumerator SlowOverTimeOnHitWithFrostBullet()
    {
        normalMovementSpeed = slowedMovementSpeed;
        yield return new WaitForSeconds(slowOverTimeDuration);
        normalMovementSpeed = maxMovementSpeed;
    }
    IEnumerator IncreasedMovementSpeed()
    {
        normalMovementSpeed = incraseMovementSpeed;
        isSpeeding = true;
        animator.SetBool("IsRunning", isSpeeding);
        yield return new WaitForSeconds(speedOverTimeDuration);
        normalMovementSpeed = maxMovementSpeed;
        isSpeeding = false;
        animator.SetBool("IsRunning", isSpeeding);
    }
    IEnumerator stopMoveIfTrapHolyKnight()
    {
        normalMovementSpeed = trapMovementSpeed;
        yield return new WaitForSeconds(trapOverTimeDuration);
        normalMovementSpeed = maxMovementSpeed;
    }
}
