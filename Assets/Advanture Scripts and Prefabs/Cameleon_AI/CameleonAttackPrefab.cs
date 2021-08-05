using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameleonAttackPrefab : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody2D bulletRB;
    public int damageDone = -20;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the player_tag ist Knight and if it's faceing an enemy from left to right, than knock him back -15 on x and 10 on y axes
        if (other.gameObject.CompareTag("Player_Knight_Advanturer") && GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(2450, 55);
        }// If the player_tag ist Knight and if it's faceing an enemy from right to left, than knock him back 15 on x and 10 on y axes
        else if (other.gameObject.CompareTag("Player_Knight_Advanturer") && GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(-2450, 55);
        }

        if (other.gameObject.CompareTag("Player_Knight_Advanturer"))
        {
            HealthKnightAdvanturer eHealth = other.gameObject.GetComponent<HealthKnightAdvanturer>();
            eHealth.ModifyHealth(damageDone);
        }
        Destroy(gameObject);
    }
}
