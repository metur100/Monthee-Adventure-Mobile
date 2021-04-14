using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateJumpForce : MonoBehaviour
{
    public GameObject jumpTrigger;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }

    public void Use()
    {
        FindObjectOfType<AudioManager>().Play("JumpForce_Item");
        Instantiate(jumpTrigger, player.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
