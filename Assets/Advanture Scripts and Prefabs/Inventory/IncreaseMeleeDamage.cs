using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMeleeDamage : MonoBehaviour
{
    public GameObject increaseDamage;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }

    public void Use()
    {
        Instantiate(increaseDamage, player.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}