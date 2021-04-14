using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailAttackPrefab : MonoBehaviour
{
    //public Rigidbody2D rb;
    public int slimeColllider = -20;
    //private float speedOfFireBall = 100f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player_Knight_Advanturer"))
        {
            HealthKnightAdvanturer eHealth = other.gameObject.GetComponent<HealthKnightAdvanturer>();
            eHealth.ModifyHealth(slimeColllider);
        }
    }
}
