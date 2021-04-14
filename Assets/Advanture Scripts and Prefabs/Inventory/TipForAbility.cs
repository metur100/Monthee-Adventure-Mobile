using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipForAbility : MonoBehaviour
{
    [SerializeField]
    private GameObject tip;
    private bool hasEntered;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_Knight_Advanturer") && !hasEntered)
        {
            hasEntered = true;
            Instantiate(tip, transform.position, Quaternion.identity);
        }
    }
}
