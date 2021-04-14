using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailWolf : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneSnail = -5;
    private int speedOfSnail = 100;
    private PlayerMovementHunter mSpeedHunter;
    private PlayerMovementKnight mSpeedKnight;
    private PlayerMovementHolyKnight mSpeedHolyKnight;
    private PlayerMovementHolyKnightNum mSpeedHolyKnightNum;
    private PlayerMovementHunterNum mSpeedHunterNum;
    private PlayerMovementKnightNum mSpeedKnightNum;
    private PlayerMovementNinjaNum mSpeedNinjaNum;
    private PlayerMovementNinja mSpeedNinja;
    void Start()
    {
        rb.velocity = transform.right * speedOfSnail;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Hunter")
        {
            HealthHunter healthNinja = other.gameObject.GetComponent<HealthHunter>();
            healthNinja.ModifyHealth(damageDoneSnail);

            mSpeedHunter = other.gameObject.GetComponent<PlayerMovementHunter>();
            //mSpeedHunter.CoroutineHunterSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Knight")
        {
            HealthKnight healthKnight = other.gameObject.GetComponent<HealthKnight>();
            healthKnight.ModifyHealth(damageDoneSnail);

            mSpeedKnight = other.gameObject.GetComponent<PlayerMovementKnight>();
           // mSpeedKnight.CoroutineKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_HolyKnight")
        {
            HealthHolyKnight healthKnight = other.gameObject.GetComponent<HealthHolyKnight>();
            healthKnight.ModifyHealth(damageDoneSnail);

            mSpeedHolyKnight = other.gameObject.GetComponent<PlayerMovementHolyKnight>();
            //mSpeedHolyKnight.CoroutineHolyKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Hunter_Num")
        {
            HealthHunterNum healthKnight = other.gameObject.GetComponent<HealthHunterNum>();
            healthKnight.ModifyHealth(damageDoneSnail);

            mSpeedHunterNum = other.gameObject.GetComponent<PlayerMovementHunterNum>();
            //mSpeedHunterNum.CoroutineHunterSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Knight_Num")
        {
            HealthKnightNum healthKnight = other.gameObject.GetComponent<HealthKnightNum>();
            healthKnight.ModifyHealth(damageDoneSnail);

            mSpeedKnightNum = other.gameObject.GetComponent<PlayerMovementKnightNum>();
           // mSpeedKnightNum.CoroutineKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            HealthHolyKnightNum healthKnight = other.gameObject.GetComponent<HealthHolyKnightNum>();
            healthKnight.ModifyHealth(damageDoneSnail);

            mSpeedHolyKnightNum = other.gameObject.GetComponent<PlayerMovementHolyKnightNum>();
           // mSpeedHolyKnightNum.CoroutineHolyKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Ninja_Num")
        {
            HealthNinjaNum healthKnight = other.gameObject.GetComponent<HealthNinjaNum>();
            healthKnight.ModifyHealth(damageDoneSnail);

            mSpeedNinjaNum = other.gameObject.GetComponent<PlayerMovementNinjaNum>();
           // mSpeedNinjaNum.CoroutineNinjaSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Ninja")
        {
            HealthNinja healthKnight = other.gameObject.GetComponent<HealthNinja>();
            healthKnight.ModifyHealth(damageDoneSnail);

            mSpeedNinja = other.gameObject.GetComponent<PlayerMovementNinja>();
          //  mSpeedNinja.CoroutineNinjaSlowOverTimeFrost();
        }
        Destroy(gameObject);
    }
}