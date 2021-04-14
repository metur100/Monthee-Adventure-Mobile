using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySmallGhostsPrefab : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField]
    private int damageDoneAOE = -500; //it deals 40 damage close range, 20 damage long range
    private readonly float speedOfMeleeAttack = 100f;

    void Start()
    {
        StartCoroutine(DestroyGameobject());
        rb.velocity = transform.right * speedOfMeleeAttack;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Mini_Ghost_AI":
                MiniGhostHealth eHealth63 = other.gameObject.GetComponent<MiniGhostHealth>();
                eHealth63.ModifyHealth(damageDoneAOE);
                break;
        }
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
