using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public GameObject currentCheckPoint;
    public PlayerMovementAdvanturerKnight player;
    public void RespawnPlayer()
    {
        player.transform.position = currentCheckPoint.transform.position;
    }
}
