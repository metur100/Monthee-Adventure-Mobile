using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateIncreaseMeleeDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_Knight_Advanturer"))
        {
            MeleePrefabKnightAdvanturer damage = collision.gameObject.GetComponent<MeleePrefabKnightAdvanturer>();
            damage.damageDoneMeleeAttack = -40;
        }
        Destroy(gameObject);
    }
}
