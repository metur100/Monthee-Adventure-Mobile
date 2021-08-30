﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBirdMoveFlip7 : MonoBehaviour
{
    private bool dirRight = true;
    public float speed;
    public Animator animator;
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector2(-60, 60);
        }

        else
        {
            transform.localScale = new Vector2(60, 60);
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x >= 2937f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 2730f)
        {
            dirRight = true;
        }
    }
}
