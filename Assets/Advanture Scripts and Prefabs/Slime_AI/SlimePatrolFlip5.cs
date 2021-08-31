using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimePatrolFlip5 : MonoBehaviour
{
    private bool dirRight = true;
    public float speed;
    public Animator animator;
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector2(-70, 70);
        }

        else
        {
            transform.localScale = new Vector2(70, 70);
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x >= 345f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 280f)
        {
            dirRight = true;
        }
    }
}
