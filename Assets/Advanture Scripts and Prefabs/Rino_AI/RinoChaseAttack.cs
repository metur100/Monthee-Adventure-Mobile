using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoChaseAttack : MonoBehaviour
{
	public float speed = 10f;
	public bool MoveRight;
	public Animator animator;
	private readonly float ignoreCollisionOverTime = 0.6f;

	void Update()
	{
		if (MoveRight)
		{
			animator.SetBool("IsWalking", true);
			transform.Translate(2 * Time.deltaTime * speed, 0, 0);
			transform.localScale = new Vector2(-60, 60);
		}
		else
		{
			animator.SetBool("IsWalking", true);
			transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
			transform.localScale = new Vector2(60, 60);
		}
	}
	void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.CompareTag("Rino_Flip"))
		{
			animator.SetTrigger("IsHitWall");
			StartCoroutine(GetDizzy());
		}
		if (trig.gameObject.CompareTag("Rino_Flip"))
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
	IEnumerator GetDizzy()
	{
		speed = 0f;
		animator.SetBool("IsWalking", false);
		yield return new WaitForSeconds(ignoreCollisionOverTime);
		speed = 50f;
		animator.SetBool("IsWalking", true);
	}
}
