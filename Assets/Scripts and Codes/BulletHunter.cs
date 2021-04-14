using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHunter : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool knockBackOnHit = false;
    public int damageDoneBullet = -20;
    private float speedOfBullet = 150f;
    void Start()
    {
        rb.velocity = transform.right * speedOfBullet;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
                                        //+++++++KNOCKBACK SCRIPT+++++++///
        // If the player_tag ist Knight and if it's faceing an enemy from left to right, than knock him back -15 on x and 10 on y axes
        if (other.tag == "Player_Knight" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_Knight" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_Knight")
        {
            HealthKnight eHealth = other.gameObject.GetComponent<HealthKnight>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        // If the player_tag ist Knight and if it's faceing an enemy from left to right, than knock him back -15 on x and 10 on y axes
        if (other.tag == "Player_Ninja" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_Ninja" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_Ninja")
        {
            HealthNinja eHealth = other.gameObject.GetComponent<HealthNinja>();
            eHealth.ModifyHealth(damageDoneBullet);
        }

        if (other.tag == "Player_HolyKnight" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_HolyKnight" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_HolyKnight")
        {
            HealthHolyKnight eHealth = other.gameObject.GetComponent<HealthHolyKnight>();
            eHealth.ModifyHealth(damageDoneBullet);
        }

        if (other.tag == "Player_Knight_Num" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_Knight_Num" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_Knight_Num")
        {
            HealthKnightNum eHealth = other.gameObject.GetComponent<HealthKnightNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
        // If the player_tag ist Knight and if it's faceing an enemy from left to right, than knock him back -15 on x and 10 on y axes
        if (other.tag == "Player_Ninja_Num" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_Ninja_Num" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_Ninja_Num")
        {
            HealthNinjaNum eHealth = other.gameObject.GetComponent<HealthNinjaNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }

        if (other.tag == "Player_HolyKnight_Num" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_HolyKnight_Num" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            HealthHolyKnightNum eHealth = other.gameObject.GetComponent<HealthHolyKnightNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }

        if (other.tag == "Player_Hunter" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_Hunter" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_Hunter")
        {
            HealthHunter eHealth = other.gameObject.GetComponent<HealthHunter>();
            eHealth.ModifyHealth(damageDoneBullet);
        }

        if (other.tag == "Player_Hunter_Num" && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-450, 15);
            knockBackOnHit = true;
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        if (other.tag == "Player_Hunter_Num" && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(450, -15);
            knockBackOnHit = true;
        }
        if (other.gameObject.tag == "Player_Hunter_Num")
        {
            HealthHunterNum eHealth = other.gameObject.GetComponent<HealthHunterNum>();
            eHealth.ModifyHealth(damageDoneBullet);
        }

        Destroy(gameObject);
    }
    //public void CoroutineNoDamageFromArrowHunter()
    //{
    //    StartCoroutine(GetNoDamageFromArrowHunter());
    //}
    //IEnumerator GetNoDamageFromArrowHunter()
    //{
    //    damageDoneBullet = damgeDoneWhenStuned;
    //    yield return new WaitForSeconds(durationOfStun);
    //    damageDoneBullet = damageDoneBulletMax;
    //}
}
