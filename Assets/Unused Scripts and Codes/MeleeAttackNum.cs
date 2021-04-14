using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeAttackNum : MonoBehaviour
{
    public Collider2D meleeTrigger;
    public Animator animator;
    public MaleTrigger dmg;
    public Image meleeAttack;
    public Image enrage;
    private bool isMaleeAttacking = false;
    private float maleeAttackTimer = 0.0f;
    private float maleeAttackSpeed = 0.01f;
    private float cooldownMaleeAttack = 1f;
    private float cooldownEnrage = 10f;
    private bool isCooldownMaleeAttack = false;
    private bool isCooldownEnrage = false;
    private bool isEnrage = false;
    private float enrageDuration = 6f;
    public int enragedMeleeDamage = -40;
    public int normalMeleeDamage = -20;

    void Start()
    {
        meleeAttack.fillAmount = 0;
        enrage.fillAmount = 0;
    }
    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        meleeTrigger.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2) && isCooldownEnrage == false)
        {
            isCooldownEnrage = true;
            enrage.fillAmount = 1;
            StartCoroutine(EnrageDamage());
            FindObjectOfType<AudioManager>().Play("Enrage");
            //FindObjectOfType<AudioManager>().Play("");
        }
        if (Input.GetButtonDown("meleeAttack2") && !isMaleeAttacking && isCooldownMaleeAttack == false)
        {
            isCooldownMaleeAttack = true;
            isMaleeAttacking = true;
            meleeAttack.fillAmount = 1;
            FindObjectOfType<AudioManager>().Play("SwordAttack");
            maleeAttackTimer = maleeAttackSpeed;
            meleeTrigger.enabled = true;
        }
        if (isCooldownEnrage)
        {
            enrage.fillAmount -= 1 / cooldownEnrage * Time.deltaTime;
            if (enrage.fillAmount <= 0)
            {
                enrage.fillAmount = 0;
                isCooldownEnrage = false;
            }
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
    IEnumerator EnrageDamage()
    {
        dmg.normalMeleeDmg = enragedMeleeDamage;
        isEnrage = true;
        animator.SetBool("IsEnrage", isEnrage);
        yield return new WaitForSeconds(enrageDuration);
        isEnrage = false;
        animator.SetBool("IsEnrage", isEnrage);
        dmg.normalMeleeDmg = normalMeleeDamage;
    }
}
