using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForceTrigger : MonoBehaviour
{
    private bool isTriggered;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_Knight_Advanturer") && !isTriggered)
        {
            isTriggered = true;
            PlayerMovementAdvanturerKnight speedBoost = collision.gameObject.GetComponent<PlayerMovementAdvanturerKnight>();
            speedBoost.jumpForce = 500f;
        }
        Destroy(gameObject);
    }
}
