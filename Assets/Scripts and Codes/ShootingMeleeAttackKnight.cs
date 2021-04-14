using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingMeleeAttackKnight : MonoBehaviour
{
    public Transform firePointMeleeAttack;
    public GameObject meleePrefab;
    public Animator animator;
    public Image shootingMeleeAttack;
    public Image enrage;
    public MeleePrefabKnight meleeDamage;
    private int enragedMeleeDmg = -40;
    private int normalMeleeDamage = -20; //it deals 40 damage close range, 20 damage long range
    private float coolddownMeleeAttacking = 2f;
    private bool isCooldownMeleeAttack = false;
    private bool isMeleeAttacking = false;
    private float maleeAttackTimer = 0.0f;
    private float maleeAttackSpeed = 0.01f;
    private bool isCooldownEnrage = false;
    private bool isEnrage = false;
    private float enrageDuration = 3f;
    private float cooldownEnrage = 10f;

    void Start()
    {
        shootingMeleeAttack.fillAmount = 0;
        enrage.fillAmount = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("meleeAttack") && isCooldownMeleeAttack == false)
        {
            isCooldownMeleeAttack = true;
            isMeleeAttacking = true;
            shootingMeleeAttack.fillAmount = 1;
            maleeAttackTimer = maleeAttackSpeed;
            ShootMeleeAttack();
            FindObjectOfType<AudioManager>().Play("SwordAttack");
        }
        if (Input.GetKeyDown(KeyCode.T) && isCooldownEnrage == false)
        {
            isCooldownEnrage = true;
            enrage.fillAmount = 1;
            StartCoroutine(EnrageDamage());
            FindObjectOfType<AudioManager>().Play("Enrage");
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
        if (isCooldownEnrage)
        {
            enrage.fillAmount -= 1 / cooldownEnrage * Time.deltaTime;
            if (enrage.fillAmount <= 0)
            {
                enrage.fillAmount = 0;
                isCooldownEnrage = false;
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

    void ShootMeleeAttack()
    {
        Instantiate(meleePrefab, firePointMeleeAttack.position, firePointMeleeAttack.rotation);
    }
    IEnumerator EnrageDamage()
    {
        meleeDamage.damageDoneMeleeAttack = enragedMeleeDmg;
        isEnrage = true;
        animator.SetBool("IsEnrage", isEnrage);
        yield return new WaitForSeconds(enrageDuration);
        isEnrage = false;
        animator.SetBool("IsEnrage", isEnrage);
        meleeDamage.damageDoneMeleeAttack = normalMeleeDamage;
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
