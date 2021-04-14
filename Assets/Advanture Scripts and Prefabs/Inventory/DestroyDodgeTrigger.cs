using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDodgeTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_Knight_Advanturer"))
        {
            Destroy(gameObject);
        }
    }
}
