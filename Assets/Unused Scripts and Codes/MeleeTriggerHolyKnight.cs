using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeTriggerHolyKnight : MonoBehaviour
{
    public int normalMeleeDmg = -20;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger != true && other.CompareTag("Player_Ninja"))
        {
            HealthNinja eHealth = other.gameObject.GetComponent<HealthNinja>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
        else if (other.isTrigger != true && other.CompareTag("Player_Hunter"))
        {
            HealthHunter eHealth = other.gameObject.GetComponent<HealthHunter>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
        else if (other.isTrigger != true && other.CompareTag("Player_Knight"))
        {
            HealthKnight eHealth = other.gameObject.GetComponent<HealthKnight>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
        else if (other.isTrigger != true && other.CompareTag("Player_HolyKnight"))
        {
            HealthHolyKnight eHealth = other.gameObject.GetComponent<HealthHolyKnight>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
        if (other.isTrigger != true && other.CompareTag("Player_Ninja_Num"))
        {
            HealthNinjaNum eHealth = other.gameObject.GetComponent<HealthNinjaNum>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
        else if (other.isTrigger != true && other.CompareTag("Player_Hunter_Num"))
        {
            HealthHunterNum eHealth = other.gameObject.GetComponent<HealthHunterNum>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
        else if (other.isTrigger != true && other.CompareTag("Player_Knight_Num"))
        {
            HealthKnightNum eHealth = other.gameObject.GetComponent<HealthKnightNum>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
        else if (other.isTrigger != true && other.CompareTag("Player_HolyKnight_Num"))
        {
            HealthHolyKnightNum eHealth = other.gameObject.GetComponent<HealthHolyKnightNum>();
            eHealth.ModifyHealth(normalMeleeDmg);
        }
    }
}
