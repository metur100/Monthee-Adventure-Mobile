using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapHunterNum : MonoBehaviour
{
    public Rigidbody2D rb;
    private PlayerMovementNinja mSpeedNinja;
    private PlayerMovementKnight mSpeedKnight;
    private PlayerMovementHolyKnight mSpeedHolyKnight;
    private PlayerMovementNinjaNum mSpeedNinjaNum;
    private PlayerMovementKnightNum mSpeedKnightNum;
    private PlayerMovementHolyKnightNum mSpeedHolyKnightNum;
    private PlayerMovementHunterNum mSpeedHunterNum;
    private PlayerMovementHunter mSpeedHunter;
    private float speedOfTrap = 100f;
    void Start()
    {
        rb.velocity = transform.right * speedOfTrap;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight")
        {
            mSpeedKnight = other.gameObject.GetComponent<PlayerMovementKnight>();
            mSpeedKnight.CoroutineMoveIfTrapKnight();

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player_HolyKnight")
        {
            mSpeedHolyKnight = other.gameObject.GetComponent<PlayerMovementHolyKnight>();
            mSpeedHolyKnight.CoroutineMoveIfTrapHolyKnight();

            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Player_Ninja")
        {
            mSpeedNinja = other.gameObject.GetComponent<PlayerMovementNinja>();
            mSpeedNinja.CoroutineMoveIfTrapNinja();

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player_Knight_Num")
        {
            mSpeedKnightNum = other.gameObject.GetComponent<PlayerMovementKnightNum>();
            mSpeedKnightNum.CoroutineMoveIfTrapKnight();

            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            mSpeedHolyKnightNum = other.gameObject.GetComponent<PlayerMovementHolyKnightNum>();
            mSpeedHolyKnightNum.CoroutineMoveIfTrapHolyKnight();

            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Player_Ninja_Num")
        {
            mSpeedNinjaNum = other.gameObject.GetComponent<PlayerMovementNinjaNum>();
            mSpeedNinjaNum.CoroutineMoveIfTrapNinja();

            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Player_Hunter")
        {
            mSpeedHunter = other.gameObject.GetComponent<PlayerMovementHunter>();
            mSpeedHunter.CoroutineMoveIfTrapHunter();

            Destroy(gameObject);
        }
    }
}
