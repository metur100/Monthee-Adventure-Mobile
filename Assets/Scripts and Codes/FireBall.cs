using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneFireB = -50;
    private float speedOfFireBall = 100f;

    void Start()
    {
        rb.velocity = transform.right * speedOfFireBall;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight")
        {
            HealthKnight eHealth = other.gameObject.GetComponent<HealthKnight>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        else if (other.gameObject.tag == "Player_Hunter")
        {
            HealthHunter eHealth = other.gameObject.GetComponent<HealthHunter>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        else if (other.gameObject.tag == "Player_HolyKnight")
        {
            HealthHolyKnight eHealth = other.gameObject.GetComponent<HealthHolyKnight>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        else if (other.gameObject.tag == "Player_Knight_Num")
        {
            HealthKnightNum eHealth = other.gameObject.GetComponent<HealthKnightNum>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        else if (other.gameObject.tag == "Player_Hunter_Num")
        {
            HealthHunterNum eHealth = other.gameObject.GetComponent<HealthHunterNum>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        else if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            HealthHolyKnightNum eHealth = other.gameObject.GetComponent<HealthHolyKnightNum>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        else if (other.gameObject.tag == "Player_Ninja_Num")
        {
            HealthNinjaNum eHealth = other.gameObject.GetComponent<HealthNinjaNum>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        else if (other.gameObject.tag == "Player_Ninja")
        {
            HealthNinja eHealth = other.gameObject.GetComponent<HealthNinja>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
        Destroy(gameObject);
    }
}
