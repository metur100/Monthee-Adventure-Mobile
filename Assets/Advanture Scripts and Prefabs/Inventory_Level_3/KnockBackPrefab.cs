using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBackPrefab : MonoBehaviour
{
    public Rigidbody2D rb;
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
            case "Chicken_AI":
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(2450, 55);
                break;
            case "Duck_AI":
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(2450, 55);
                break;
            case "Cameleon_AI":
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(2450, 55);
                break;
            case "RedBird_AI":
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(2450, 55);
                break;
            case "GreenPlant_AI":
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(2450, 55);
                break;
        }
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(0.09f);
        Destroy(gameObject);
    }
}
