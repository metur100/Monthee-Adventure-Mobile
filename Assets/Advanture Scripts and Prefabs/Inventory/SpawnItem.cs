using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    private Transform playerPos;
    public GameObject item;
    private void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }
    public void Spawn()
    {
        Vector2 playerPosition = new Vector2(playerPos.position.x + 20, playerPos.position.y);
        Instantiate(item, playerPosition, Quaternion.identity);
    }
}
