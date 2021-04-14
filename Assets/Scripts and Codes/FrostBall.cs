using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneFrostB = -20;  
    private int speedOfFrostBullet = 100;
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
        rb.velocity = transform.right * speedOfFrostBullet;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Hunter")
        {
            HealthHunter healthNinja = other.gameObject.GetComponent<HealthHunter>();
            healthNinja.ModifyHealth(damageDoneFrostB);

            mSpeedHunter = other.gameObject.GetComponent<PlayerMovementHunter>();
            mSpeedHunter.CoroutineHunterSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Knight")
        {
            HealthKnight healthKnight = other.gameObject.GetComponent<HealthKnight>();
            healthKnight.ModifyHealth(damageDoneFrostB);

            mSpeedKnight = other.gameObject.GetComponent<PlayerMovementKnight>();
            mSpeedKnight.CoroutineKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_HolyKnight")
        {
            HealthHolyKnight healthKnight = other.gameObject.GetComponent<HealthHolyKnight>();
            healthKnight.ModifyHealth(damageDoneFrostB);

            mSpeedHolyKnight = other.gameObject.GetComponent<PlayerMovementHolyKnight>();
            mSpeedHolyKnight.CoroutineHolyKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Hunter_Num")
        {
            HealthHunterNum healthKnight = other.gameObject.GetComponent<HealthHunterNum>();
            healthKnight.ModifyHealth(damageDoneFrostB);

            mSpeedHunterNum = other.gameObject.GetComponent<PlayerMovementHunterNum>();
            mSpeedHunterNum.CoroutineHunterSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Knight_Num")
        {
            HealthKnightNum healthKnight = other.gameObject.GetComponent<HealthKnightNum>();
            healthKnight.ModifyHealth(damageDoneFrostB);

            mSpeedKnightNum = other.gameObject.GetComponent<PlayerMovementKnightNum>();
            mSpeedKnightNum.CoroutineKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            HealthHolyKnightNum healthKnight = other.gameObject.GetComponent<HealthHolyKnightNum>();
            healthKnight.ModifyHealth(damageDoneFrostB);

            mSpeedHolyKnightNum = other.gameObject.GetComponent<PlayerMovementHolyKnightNum>();
            mSpeedHolyKnightNum.CoroutineHolyKnightSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Ninja_Num")
        {
            HealthNinjaNum healthKnight = other.gameObject.GetComponent<HealthNinjaNum>();
            healthKnight.ModifyHealth(damageDoneFrostB);

            mSpeedNinjaNum = other.gameObject.GetComponent<PlayerMovementNinjaNum>();
            mSpeedNinjaNum.CoroutineNinjaSlowOverTimeFrost();
        }

        if (other.gameObject.tag == "Player_Ninja")
        {
            HealthNinja healthKnight = other.gameObject.GetComponent<HealthNinja>();
            healthKnight.ModifyHealth(damageDoneFrostB);

            mSpeedNinja = other.gameObject.GetComponent<PlayerMovementNinja>();
            mSpeedNinja.CoroutineNinjaSlowOverTimeFrost();
        }
        Destroy(gameObject);
    }
}   