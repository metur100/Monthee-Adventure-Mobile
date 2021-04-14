using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class DashMoveButton : MonoBehaviour
{
    public Image dashing;
    public Animator animator;
    public Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    private readonly float startDashTime = 0.2f;
    private int direction;
    private readonly float dashCooldown = 0.4f;
    private bool isDashCooldown = false;
    public ParticleSystem dash;
    private bool isPressed = false;
    CharacterController2D facing;

    void Start()
    {
        dash.Stop();
        dashing.fillAmount = 0;
        dashTime = startDashTime;
        facing = GetComponent<CharacterController2D>();
    }
    void Update()
    {
        if (direction == 0)
        {
            if (isPressed && isDashCooldown == false && !facing.m_FacingRight)
            {
                dash.Play();
                isDashCooldown = true;
                dashing.fillAmount = 1;
                direction = 1;
                CameraShaker.Instance.ShakeOnce(.5f, .9f, 0.1f, 0.2f);
                FindObjectOfType<AudioManager>().Play("Dash");
                isPressed = false;
            }
            else if (isPressed && isDashCooldown == false && facing.m_FacingRight)
            {
                dash.Play();
                isDashCooldown = true;
                dashing.fillAmount = 1;
                direction = 2;
                CameraShaker.Instance.ShakeOnce(.5f, .9f, 0.1f, 0.2f);
                FindObjectOfType<AudioManager>().Play("Dash");
                isPressed = false;
            }
            if (isDashCooldown)
            {
                dashing.fillAmount -= 1 / dashCooldown * Time.deltaTime;
                if (dashing.fillAmount <= 0)
                {
                    dashing.fillAmount = 0;
                    isDashCooldown = false;
                }
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
                if (direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                else if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
            }
        }
    }
    public void Execute()
    {
        isPressed = true;
    }
}