using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlying : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float normalMovementSpeed;
    private float horizontalMove = 0f;

    public float jumpForce;

    public Joystick joystick;
    void Update()
    {
        if (joystick.Horizontal >= 0.2f)
        {
            horizontalMove = normalMovementSpeed;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            horizontalMove = -normalMovementSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }
        float verticalMove = joystick.Vertical;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (verticalMove >= .5f)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
        }
        if (verticalMove >= -.5f)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * jumpForce);
        }
    }
}
