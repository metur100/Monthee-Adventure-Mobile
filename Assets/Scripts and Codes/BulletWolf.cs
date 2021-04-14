using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWolf : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneBullet = -30;
    private float speedOfBullet = 150f;
    void Start()
    {
        rb.velocity = transform.right * speedOfBullet;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight")
        {
            HealthKnight eHealth = other.gameObject.GetComponent<HealthKnight>();
            eHealth.ModifyHealth(damageDoneBullet);
        }

        if (other.gameObject.tag == "Player_Ninja")
        {
            HealthNinja eHealth = other.gameObject.GetComponent<HealthNinja>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_HolyKnight")
        {
            HealthHolyKnight eHealth = other.gameObject.GetComponent<HealthHolyKnight>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_Knight_Num")
        {
            HealthKnightNum eHealth = other.gameObject.GetComponent<HealthKnightNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_Ninja_Num")
        {
            HealthNinjaNum eHealth = other.gameObject.GetComponent<HealthNinjaNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            HealthHolyKnightNum eHealth = other.gameObject.GetComponent<HealthHolyKnightNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_Hunter")
        {
            HealthHunter eHealth = other.gameObject.GetComponent<HealthHunter>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_Hunter_Num")
        {
            HealthHunterNum eHealth = other.gameObject.GetComponent<HealthHunterNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_Wolf")
        {
            HealthWolf eHealth = other.gameObject.GetComponent<HealthWolf>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        if (other.gameObject.tag == "Player_Wolf_Num")
        {
            HealthWolfNum eHealth = other.gameObject.GetComponent<HealthWolfNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        Destroy(gameObject);
    }
}
