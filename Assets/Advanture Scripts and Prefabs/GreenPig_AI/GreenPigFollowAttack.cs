using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPigFollowAttack : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float chasingDistance;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public Rigidbody2D rb;

    public GameObject projectile;
    public GameObject shootingPoint;
    public Animator animator;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance && Vector2.Distance(transform.position, player.position) > chasingDistance)
            {
                //startingPoint = standing
                transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, player.position) > stoppingDistance && Vector2.Distance(transform.position, player.position) < chasingDistance)
            {
                //animator.SetTrigger("IsDesappearing");
                //chasing and shooting
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), speed * Time.deltaTime);
                if (timeBtwShots <= 0)
                {
                    animator.SetTrigger("IsAttacking");
                    Instantiate(projectile, shootingPoint.transform.position, Quaternion.identity);
                    timeBtwShots = startTimeBtwShots;
                }
                else
                {
                    timeBtwShots -= Time.deltaTime;
                }
            }
            else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                //shooting
                //animator.SetTrigger("IsAppearing");
                transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
            {
                //retreating
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), -speed * Time.deltaTime);
            }
        }
    }
}
