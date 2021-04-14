using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataProfile : MonoBehaviour
{
    public int currentQuestProgress;
    public int currentHealth;
    public float[] position;

    public PlayerDataProfile (QuestGoal current, HealthKnightAdvanturer health, PlayerKnightPosition pos)
    {
        currentQuestProgress = current.currentAmount;
        currentHealth = health.currentHealth;

        position = new float[2];
        position[0] = pos.transform.position.x;
        position[1] = pos.transform.position.y;
    }
}
