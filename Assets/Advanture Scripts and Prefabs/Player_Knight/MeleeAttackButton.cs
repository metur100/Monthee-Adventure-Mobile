using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using EZCameraShake;

public class MeleeAttackButton : MonoBehaviour
{
    public Transform firePointMeleeAttack;
    public GameObject meleePrefab;
    public Animator animator;
    public Image shootingMeleeAttack;
    public MeleePrefabKnightAdvanturer meleeDamage;
    private readonly float coolddownMeleeAttacking = 0.5f;
    private bool isCooldownMeleeAttack = false;
    private bool isMeleeAttacking = false;
    private float maleeAttackTimer = 0.0f;
    private float maleeAttackSpeed = 0.01f;
    private bool isPressed;

    void Start()
    {
        shootingMeleeAttack.fillAmount = 0;
        isPressed = false;
    }
    public void Update()
    {
        if (isPressed && isCooldownMeleeAttack == false)
        {
            Instantiate(meleePrefab, firePointMeleeAttack.position, firePointMeleeAttack.rotation);
            isCooldownMeleeAttack = true;
            isMeleeAttacking = true;
            shootingMeleeAttack.fillAmount = 1;
            maleeAttackTimer = maleeAttackSpeed;
            ShootMeleeAttack();
            FindObjectOfType<AudioManager>().Play("SwordAttack");
        }
        isPressed = false;
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
        animator.SetBool("IsAttacking", isMeleeAttacking);
    }
    public void ShootMeleeAttack()
    {
        isPressed = true;       
    }
}
