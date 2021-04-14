using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour 
{
    public HealthKnightAdvanturer health;
    public Animator anim;
    public bool isDead;
    private void Update()
    {
        if (health.currentHealth <= 100) {
            anim.SetTrigger("stageTwo");
        }
        if (health.currentHealth <= 0) {
            anim.SetTrigger("death");
        }
    }
}
