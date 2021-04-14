using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public GoalType goalType;
    public int requiredAmount;
    public int currentAmount;
    public bool IsReached()
    {
        return (currentAmount == requiredAmount);
    }
    public void EnemyKilled()
    {
        if (goalType == GoalType.Kill)
        {
            currentAmount++;
            TrackQuestProgress.scoreValue++;
        }
    }
    public void ItemCollected()
    {
        if (goalType == GoalType.Gethering)
        {
            currentAmount++;
            TrackQuestProgressRunes.scoreValue++;
        }
    }
}
public enum GoalType
{
    Kill,
    Gethering
}