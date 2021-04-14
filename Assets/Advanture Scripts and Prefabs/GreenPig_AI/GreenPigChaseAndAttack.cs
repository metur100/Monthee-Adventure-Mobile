using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPigChaseAndAttack : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    Rigidbody2D rb2d;
    public float agroRange;
    public float speed;
    [SerializeField]
    private float shootingRange;
    [SerializeField]
    private float bodyRange;
    private readonly float fireRate = 1f;
    private float nextFireTime;
    private bool isWalking = true;
    public Animator animator;
    private readonly float localScaleX = 15;
    private readonly float localScaleMinusX = -15;
    private readonly float localScaleY = 15;
    [SerializeField]
    private GameObject bulletPos;
    [SerializeField]
    private GameObject attackPrefab;
    void Update()
    {
        if (player != null)
        {
            float distToPlayer = Vector2.Distance(transform.position, player.position);
            if (distToPlayer < agroRange && distToPlayer > shootingRange)
            {
                isWalking = true;
                animator.SetBool("IsWalking", isWalking);
                ChasePlayer();
            }
            else if (distToPlayer <= shootingRange && nextFireTime < Time.time)
            {
                animator.SetTrigger("IsAttacking");
                isWalking = false;
                animator.SetBool("IsWalking", isWalking);
                FindObjectOfType<AudioManager>().Play("Trunk_Attack");
                StartShooting();
                nextFireTime = Time.time + fireRate;
            }
            else if (distToPlayer <= bodyRange)
            {
                isWalking = true;
                animator.SetBool("IsWalking", isWalking);
                transform.position = Vector2.MoveTowards(transform.position, new Vector2 (player.position.x, transform.position.y), -speed * Time.deltaTime);
            }
            else
            {
                isWalking = false;
                animator.SetBool("IsWalking", isWalking);
                StopChasingPlayer();
            }
        }
    }
    private void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }
    private void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(localScaleMinusX, localScaleY);
        }
        else
        {
            rb2d.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(localScaleX, localScaleY);
        }
    }
    private void StartShooting()
    {
        Instantiate(attackPrefab, bulletPos.transform.position, Quaternion.identity);
    }
}
