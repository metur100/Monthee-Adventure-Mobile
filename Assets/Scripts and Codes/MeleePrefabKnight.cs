using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleePrefabKnight : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneMeleeAttack = -20; //it deals 40 damage close range, 20 damage long range
    private float speedOfMeleeAttack = 100f;

    void Start()
    {
        StartCoroutine(DestroyGameobject());
        rb.velocity = transform.right * speedOfMeleeAttack;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight")
        {
            HealthKnight eHealth = other.gameObject.GetComponent<HealthKnight>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
        else if (other.gameObject.tag == "Player_Hunter")
        {
            HealthHunter eHealth = other.gameObject.GetComponent<HealthHunter>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
        else if (other.gameObject.tag == "Player_HolyKnight")
        {
            HealthHolyKnight eHealth = other.gameObject.GetComponent<HealthHolyKnight>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
        else if (other.gameObject.tag == "Player_Knight_Num")
        {
            HealthKnightNum eHealth = other.gameObject.GetComponent<HealthKnightNum>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
        else if (other.gameObject.tag == "Player_Hunter_Num")
        {
            HealthHunterNum eHealth = other.gameObject.GetComponent<HealthHunterNum>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
        else if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            HealthHolyKnightNum eHealth = other.gameObject.GetComponent<HealthHolyKnightNum>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
        else if (other.gameObject.tag == "Player_Ninja_Num")
        {
            HealthNinjaNum eHealth = other.gameObject.GetComponent<HealthNinjaNum>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
        else if (other.gameObject.tag == "Player_Ninja")
        {
            HealthNinja eHealth = other.gameObject.GetComponent<HealthNinja>();
            eHealth.ModifyHealth(damageDoneMeleeAttack);
        }
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(0.07f);
        Destroy(gameObject);
    }
}