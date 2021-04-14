using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolStopGo : MonoBehaviour
{
	public float speed = 10f;
	public bool MoveRight;
	public Animator animator;
	private bool isInvulnerable = false;
	private float ignoreCollisionOverTime = 3.4f;
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
		if (trig.gameObject.CompareTag("Hide_AI"))
        {
			StartCoroutine(GetInvulnerable());
		}
	}
	IEnumerator GetInvulnerable()
	{
		Physics2D.IgnoreLayerCollision(21, 11, true);;
		speed = 0f;
		isInvulnerable = true;
		animator.SetBool("IsHiding", isInvulnerable);
		yield return new WaitForSeconds(ignoreCollisionOverTime);
		speed = 10f;
		isInvulnerable = false;
		animator.SetBool("IsHiding", isInvulnerable);
		Physics2D.IgnoreLayerCollision(21, 11, false);
	}
}
