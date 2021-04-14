using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyAttackPrefab : MonoBehaviour
{
    public int bodyAttack; //it does double damage, it is -40, even though it is initalized as -20
    private bool isDamaged;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player_Knight_Advanturer") && !isDamaged)
        {
            isDamaged = true;
            HealthKnightAdvanturer eHealth = other.gameObject.GetComponent<HealthKnightAdvanturer>();
            eHealth.ModifyHealth(bodyAttack);
        }
        StartCoroutine(RestartIsDamage());
    }
    IEnumerator RestartIsDamage()
    {
        yield return new WaitForSeconds(2f);
        isDamaged = false;
    }
}
