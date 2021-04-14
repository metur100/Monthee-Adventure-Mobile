using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseExpCoin : MonoBehaviour
{
    public int expCollider;
    public GameObject expEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player_Knight_Advanturer"))
        {
            FindObjectOfType<AudioManager>().Play("Exp_Item");
            Instantiate(expEffect, transform.position, Quaternion.identity);
            ExpKnight exp = other.gameObject.GetComponent<ExpKnight>();
            exp.ModifyExp(expCollider);
            Destroy(gameObject);
        }
    }
}
