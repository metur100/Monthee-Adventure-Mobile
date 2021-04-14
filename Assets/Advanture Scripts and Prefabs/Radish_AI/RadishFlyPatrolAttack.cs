using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadishFlyPatrolAttack : MonoBehaviour
{
	public float speed = 10f;
	public bool MoveRight;
	public Animator animator;
    public Rigidbody2D rb;
    public Transform player;
	public float shootingDistance;

	public GameObject bulletPrefab;
	public Transform shootingPoint;

	private float timeBtwShots;
	public float startTimeBtwShots;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
	}
	void Update()
	{
		if (player != null)
		{
			if (Vector2.Distance(transform.position, player.position) < shootingDistance)
			{
				if (timeBtwShots <= 0)
				{
					animator.SetTrigger("IsAttacking");
					Instantiate(bulletPrefab, shootingPoint.transform.position, Quaternion.identity);
					timeBtwShots = startTimeBtwShots;
				}
				else
				{
					timeBtwShots -= Time.deltaTime;
				}
			}
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
		if (trig.gameObject.CompareTag("ShootAtMe"))
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
