using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleAttackPrefab : MonoBehaviour
{
    //public Rigidbody2D rb;
    public int turtleColllider = -20;
    //private float speedOfFireBall = 100f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight_Advanturer")
        {
            HealthKnightAdvanturer eHealth = other.gameObject.GetComponent<HealthKnightAdvanturer>();
            eHealth.ModifyHealth(turtleColllider);
        }
    }
}