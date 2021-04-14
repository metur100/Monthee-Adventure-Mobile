using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDamage : MonoBehaviour
{
    //public Rigidbody2D rb;
    public int damageDoneFireB = -20;
    //private float speedOfFireBall = 100f;

    void Start()
    {
        //rb.velocity = transform.right * speedOfFireBall;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight_Advanturer")
        {
            HealthKnightAdvanturer eHealth = other.gameObject.GetComponent<HealthKnightAdvanturer>();
            eHealth.ModifyHealth(damageDoneFireB);
        }
    }
}
