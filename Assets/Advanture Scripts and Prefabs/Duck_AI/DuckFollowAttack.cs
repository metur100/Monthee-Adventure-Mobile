using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckFollowAttack : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float agroRange;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float shootingRange;
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    GameObject bulletParent;
    private readonly float fireRate = 1f;
    private float nextFireTime;
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
            if (distToPlayer < agroRange && distToPlayer > shootingRange)
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
            else if (distToPlayer <= shootingRange && nextFireTime < Time.time)
            {
                animator.SetTrigger("IsAttacking");
                isWalking = false;
                animator.SetBool("IsWalking", isWalking);
                FindObjectOfType<AudioManager>().Play("Duck_Attack");
                StartShooting();
                nextFireTime = Time.time + fireRate;
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
            Vector2 target = new Vector2(player.position.x, transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
            //rb2d.velocity = new Vector2(moveSpeed, 0);
            rb2d.AddForce(Vector2.up * 2000000f);
            transform.localScale = new Vector2(-70, 70);
        }
        else
        {
            Vector2 target = new Vector2(player.position.x, transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
            //rb2d.velocity = new Vector2(-moveSpeed, 0);
            rb2d.AddForce(Vector2.up * 2000000f);
            transform.localScale = new Vector2(70, 70);
        }
    }
    private void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }
    private void StartShooting()
    {
        Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
    }
}