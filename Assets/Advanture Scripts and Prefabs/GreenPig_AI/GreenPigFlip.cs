using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPigFlip : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float agroRange;
    //[SerializeField]
    //Rigidbody2D rb2d;
    //public float speed;
    //private bool isWalking = true;
    public Animator animator;
    //public float attackingDistance;
    void Update()
    {
        if (player != null)
        {
            float distToPlayer = Vector2.Distance(transform.position, player.position);
            if (distToPlayer < agroRange)
            {
                //isWalking = true;
                //animator.SetBool("IsWalking", isWalking);
                ChasePlayer();
            }
            //else if (Vector2.Distance(transform.position, player.position) <= attackingDistance)
            //{
            //    animator.SetTrigger("IsAttacking");
            //}
            //else
            //{
            //    isWalking = false;
            //    animator.SetBool("IsWalking", isWalking);
            //    StopChasingPlayer();
            //}
        }
    }
    //private void StopChasingPlayer()
    //{
    //    rb2d.velocity = new Vector2(0, 0);
    //}
    private void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            transform.localScale = new Vector2(-15, 15);
        }
        else
        {
            transform.localScale = new Vector2(15, 15);
        }
    }
}
