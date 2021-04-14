using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position;

    public PlayerData (PlayerKnightPosition pos)
    {
        //health = currHealth.currentHealth;
        position = new float[2];
        position[0] = pos.transform.position.x;
        position[1] = pos.transform.position.y;
    }
}
