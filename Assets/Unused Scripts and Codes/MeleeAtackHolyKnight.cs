using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeAtackHolyKnight : MonoBehaviour
{
    public Collider2D meleeTrigger;
    public Animator animator;
    public MeleeTriggerHolyKnight dmg;
    public Image meleeAttack;
    private bool isMaleeAttacking = false;
    private float maleeAttackTimer = 0.0f;
    private float maleeAttackSpeed = .001f;
    private float cooldownMaleeAttack = 1f;
    private bool isCooldownMaleeAttack = false;
    public int normalMeleeDamage = -20;

    void Start()
    {
        meleeAttack.fillAmount = 0;
    }
    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        meleeTrigger.enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("meleeAttack") && !isMaleeAttacking && isCooldownMaleeAttack == false)
        {
            isCooldownMaleeAttack = true;
            isMaleeAttacking = true;
            meleeAttack.fillAmount = 1;
            FindObjectOfType<AudioManager>().Play("SwordAttack");
            maleeAttackTimer = maleeAttackSpeed;
            meleeTrigger.enabled = true;
        }
        if (isCooldownMaleeAttack)
        {
            meleeAttack.fillAmount -= 1 / cooldownMaleeAttack * Time.deltaTime;
            if (meleeAttack.fillAmount <= 0)
            {
                meleeAttack.fillAmount = 0;
                isCooldownMaleeAttack = false;
            }
        }
        if (isMaleeAttacking)
        {
            if (maleeAttackTimer > 0)
            {
                maleeAttackTimer -= Time.deltaTime;
            }
            else
            {
                isMaleeAttacking = false;
                meleeTrigger.enabled = false;
            }
        }
        animator.SetBool("IsAttacking", isMaleeAttacking);
    }
}
