using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyJumpFlip2 : MonoBehaviour
{
    private bool dirRight = true;
    public float speed;
    public Animator animator;
    public Rigidbody2D rb;
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector2(-50, 50);
        }

        else
        {
            transform.localScale = new Vector2(50, 50);
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x >= 7010f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 6679f)
        {
            dirRight = true;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "BigStump":
                rb.AddForce(Vector2.up * 2000f);
                animator.SetTrigger("IsJumping");
                break;
        }
    }
}
