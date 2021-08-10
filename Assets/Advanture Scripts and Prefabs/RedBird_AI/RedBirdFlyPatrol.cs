using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBirdFlyPatrol : MonoBehaviour
{
	public float speed;
	public bool MoveRight;
	public Animator animator;

	public float stoppingDistance;
	public float chasingDistance;

	private float timeBtwShots;
	public float startTimeBtwShots;
	public GameObject attackPrefab;
	public GameObject shootingPoint;

	public Rigidbody2D rb;
	Transform player;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
		timeBtwShots = startTimeBtwShots;
	}
	void Update()
	{
		if (Vector2.Distance(transform.position, player.position) > stoppingDistance && Vector2.Distance(transform.position, player.position) < chasingDistance)
		{
			if (player.position.x > transform.position.x)
			{
				//face right
				transform.localScale = new Vector2(-60, 60);
			}
			else if (player.position.x < transform.position.x)
			{
				//face left
				transform.localScale = new Vector2(60, 60);
			}

			transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

			if (timeBtwShots <= 0)
			{
				Instantiate(attackPrefab, shootingPoint.transform.position, Quaternion.identity);
				timeBtwShots = startTimeBtwShots;
			}
			else
			{
				timeBtwShots -= Time.deltaTime;
			}
		}
        else
        {
			if (MoveRight)
			{
				transform.Translate(2 * Time.deltaTime * speed, 0, 0);
				transform.localScale = new Vector2(-60, 60);
			}
			else
			{
				transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
				transform.localScale = new Vector2(60, 60);
			}
		}
	}
	void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.CompareTag("Flip"))
		{
			if (MoveRight)
			{
				MoveRight = false;
			}
			else
			{
				MoveRight = true;
			}
		}
	}
}
