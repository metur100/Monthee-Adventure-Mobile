using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAIHealth : MonoBehaviour
{
    public HealthKnightAdvanturer healthPlayer;
    public SlimeHealthPatrol healthSlime1;

    private void Start()
    {
        healthPlayer = gameObject.GetComponent<HealthKnightAdvanturer>();
    }
    private void Update()
    {
        if (healthPlayer.currentHealth <= 0)
        {
            healthSlime1.ModifyHealth(80);
        }
    }
}
