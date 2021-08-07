using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFollowAttack : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float agroRange;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    Rigidbody2D rb2d;
    public Animator animator;
    private bool isWalking = false;
    public Transform groundDetection;
    public float distance;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (player != null)
        {
            float distToPlayer = Vector2.Distance(transform.position, player.position);
            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
            if (distToPlayer < agroRange)
            {
                if (groundInfo.collider == false)
                {
                    StopChasingPlayer();
                }
                else
                {
                    isWalking = true;
                    animator.SetBool("IsWalking", isWalking);
                    ChasePlayer();
                }
            }
            else
            {
                isWalking = false;
                animator.SetBool("IsWalking", isWalking);
                StopChasingPlayer();
            }
        }
    }
    private void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(-70, 70);
        }
        else
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(70, 70);
        }
    }
    private void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }
}
