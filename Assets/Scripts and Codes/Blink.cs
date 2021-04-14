using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public Image blinking;
    private float blinkDistance = 25f;
    private float blinkTimer;
    private float blinkTime = 1f;
    private bool facingRight;
    private bool canBlink = true;
    private bool isBlinkCooldown = false;
    private float blinkCooldown = 2f;

    void Start()
    {
        blinking.fillAmount = 0;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canBlink && isBlinkCooldown == false)
        {
            // PlaySound(0);
            animator.SetBool("isBlinking", true);
            blinking.fillAmount = 1;
            canBlink = false;
            isBlinkCooldown = true;
            FindObjectOfType<AudioManager>().Play("BlinkMage");
        }
        else
            animator.SetBool("isBlinking", false);

        if (!canBlink)
        {
            blinkTimer += Time.deltaTime;
        }
        if (blinkTimer > blinkTime)
        {
            canBlink = true;
            blinkTimer = 0;
        }
        if (transform.right.x == 1)
        {
            facingRight = true;
        }
        else
        {
            facingRight = false;
        }
        if (isBlinkCooldown)
        {
            blinking.fillAmount -= 1 / blinkCooldown * Time.deltaTime;
            if (blinking.fillAmount <= 0)
            {
                blinking.fillAmount = 0;
                isBlinkCooldown = false;
            }
        }
    }
    void Blinking()
    {
        Vector3 blink;
        if (facingRight)
            blink = new Vector3(blinkDistance, 0, 0);
        else
            blink = new Vector3(-blinkDistance, 0, 0);

        transform.position += blink;
    }
}