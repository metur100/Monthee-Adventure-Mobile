using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingMeleeAttackHolyKnightNum : MonoBehaviour
{
    public Transform firePointMeleeAttack;
    public GameObject meleePrefab;
    public Animator animator;
    public Image shootingMeleeAttack;
    private float coolddownMeleeAttacking = 2f;
    private bool isCooldownMeleeAttack = false;
    private bool isMeleeAttacking = false;
    private float maleeAttackTimer = 0.0f;
    private float maleeAttackSpeed = 0.01f;

    void Start()
    {
        shootingMeleeAttack.fillAmount = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("meleeAttack2") && isCooldownMeleeAttack == false)
        {
            isCooldownMeleeAttack = true;
            isMeleeAttacking = true;
            shootingMeleeAttack.fillAmount = 1;
            maleeAttackTimer = maleeAttackSpeed;
            animator.SetTrigger("MeleeAttack");
            ShootMeleeAttack();
            FindObjectOfType<AudioManager>().Play("SwordAttackHolyKnight");
            //StartCoroutine(IsAttackingAnimation());
        }
        if (isCooldownMeleeAttack)
        {
            shootingMeleeAttack.fillAmount -= 1 / coolddownMeleeAttacking * Time.deltaTime;
            if (shootingMeleeAttack.fillAmount <= 0)
            {
                shootingMeleeAttack.fillAmount = 0;
                isCooldownMeleeAttack = false;
            }
        }
        if (isMeleeAttacking)
        {
            if (maleeAttackTimer > 0)
            {
                maleeAttackTimer -= Time.deltaTime;
            }
            else
            {
                isMeleeAttacking = false;
            }
        }
        //animator.SetBool("IsAttacking", isMeleeAttacking);
    }

    void ShootMeleeAttack()
    {
        Instantiate(meleePrefab, firePointMeleeAttack.position, firePointMeleeAttack.rotation);
    }
    //IEnumerator IsAttackingAnimation()
    //{
    //    isMeleeAttacking = true;
    //    animator.SetBool("IsAttacking", isMeleeAttacking);
    //    yield return new WaitForSeconds(0.01f);
    //    isMeleeAttacking = false;
    //    animator.SetBool("IsAttacking", isMeleeAttacking);
    //}
}
