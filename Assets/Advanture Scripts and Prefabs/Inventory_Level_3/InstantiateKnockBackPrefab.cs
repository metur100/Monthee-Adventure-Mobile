using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateKnockBackPrefab : MonoBehaviour
{
    public GameObject prefabKnockBack;
    public Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }
    public void Use()
    {
        if (player != null)
        {
            FindObjectOfType<AudioManager>().Play("GreenBullet_Item");
            Instantiate(prefabKnockBack, player.transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
