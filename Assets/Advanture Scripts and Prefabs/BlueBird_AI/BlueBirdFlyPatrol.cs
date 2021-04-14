using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBirdFlyPatrol : MonoBehaviour
{
	public float speed = 10f;
	public bool MoveRight;
	public Animator animator;
	void Update()
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
