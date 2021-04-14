using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class ShootingDestroyWall : MonoBehaviour
{
    public GameObject prefabWall;
    //public GameObject effect;
    public Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }
    public void Use()
    {
        FindObjectOfType<AudioManager>().Play("Destroy_Wall");
        Instantiate(prefabWall, player.transform.position, Quaternion.identity);
        //Instantiate(effect, player.transform.position, Quaternion.identity);
        CameraShaker.Instance.ShakeOnce(.9f, .7f, 0.2f, 0.2f);
        Destroy(gameObject);
    }
}