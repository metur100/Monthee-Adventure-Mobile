using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundEnemies : MonoBehaviour
{
    public string soundEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player_Knight_Advanturer"))
        {
            FindObjectOfType<AudioManager>().Play(soundEffect);
        }
    }
}
