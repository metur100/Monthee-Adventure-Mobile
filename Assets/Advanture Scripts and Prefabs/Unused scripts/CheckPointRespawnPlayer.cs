using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointRespawnPlayer : MonoBehaviour
{
    public RespawnManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<RespawnManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player_Knight_Advanturer")
        {
            levelManager.currentCheckPoint = gameObject;
        }
    }
}
