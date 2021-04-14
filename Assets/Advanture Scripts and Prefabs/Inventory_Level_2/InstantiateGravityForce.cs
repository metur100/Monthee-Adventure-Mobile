using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGravityForce : MonoBehaviour
{
    public GameObject gravityTrigger;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }

    public void Use()
    {
        FindObjectOfType<AudioManager>().Play("Gravity_Item");
        Instantiate(gravityTrigger, player.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
