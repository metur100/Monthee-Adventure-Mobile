using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashMove : MonoBehaviour
{
    public Image dashing;
    public Animator animator;
    private Rigidbody2D rb;
    private float dashSpeed = 100f;
    private float dashTime;
    private float startDashTime = 0.5f;
    private int direction; 
    private bool isDashing = false; 
    private float dashCooldown = 3f;
    private bool isDashCooldown = false;

    void Start()
    {
        dashing.fillAmount = 0;
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }
    void Update()
    {
         if (direction == 0)
         {
             if (Input.GetKeyDown(KeyCode.Q) && isDashCooldown == false)
             {
                isDashCooldown = true;
                dashing.fillAmount = 1;
                isDashing = true;
                direction = 1;
                FindObjectOfType<AudioManager>().Play("Dash");
             }
             else if (Input.GetKeyDown(KeyCode.E) && isDashCooldown == false)
             {
                isDashing = true;
                isDashCooldown = true;
                dashing.fillAmount = 1;
                direction = 2;
                FindObjectOfType<AudioManager>().Play("Dash");
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
                    isDashing = false;
                }
                else if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                    isDashing = false;
                }
            }
        }
       animator.SetBool("isDashing", isDashing);
    }
}