﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoChaseFlip2 : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 20.0f;
    public Animator animator;
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector2(-60, 60);
            animator.SetBool("IsWalking", true);
        }

        else
        {
            transform.localScale = new Vector2(60, 60);
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            animator.SetBool("IsWalking", true);
        }

        if (transform.position.x >= 8910f)
        {
            dirRight = false;
            animator.SetTrigger("IsHitWall");
        }

        if (transform.position.x <= 8820f)
        {
            dirRight = true;
            animator.SetTrigger("IsHitWall");
        }
    }
}
