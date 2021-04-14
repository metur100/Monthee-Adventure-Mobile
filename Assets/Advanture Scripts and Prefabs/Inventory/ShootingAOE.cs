using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ShootingAOE : MonoBehaviour
{
    public GameObject preabAOE;
    public GameObject explosionEffect;
    public Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }

    public void Use()
    {
        if (player != null)
        {
            FindObjectOfType<AudioManager>().Play("AOE_Item");
            Instantiate(preabAOE, player.transform.position, Quaternion.identity);
            Instantiate(explosionEffect, player.transform.position, Quaternion.identity);
            CameraShaker.Instance.ShakeOnce(.9f, .7f, 0.2f, 0.2f);
            Destroy(gameObject);
        }
    }
}