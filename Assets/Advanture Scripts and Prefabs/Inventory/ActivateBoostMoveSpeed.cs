using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBoostMoveSpeed : MonoBehaviour
{
    public GameObject speedEffect;
    private Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }

    public void Use()
    {
        Instantiate(speedEffect, player.transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("Speed_Item");
        Destroy(gameObject);
    }
}
