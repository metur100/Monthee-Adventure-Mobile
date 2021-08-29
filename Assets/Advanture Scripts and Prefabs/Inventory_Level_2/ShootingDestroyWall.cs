using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class ShootingDestroyWall : MonoBehaviour
{
    public GameObject prefabWall;
    public GameObject tip;
    public Transform player;
    public Transform wall;
    public float radius;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }
    public void InstantiateObjectOnlyInSpecificArea()
    {
        float distance = Vector2.Distance(player.transform.position, wall.transform.position);
        if (distance <= radius)
        {
            Use();
        }
        else
        {
            Instantiate(tip, player.transform.position, Quaternion.identity);
        }
    }
    public void Use()
    {
        FindObjectOfType<AudioManager>().Play("Destroy_Wall");
        Instantiate(prefabWall, player.transform.position, Quaternion.identity);
        CameraShaker.Instance.ShakeOnce(.9f, .7f, 0.2f, 0.2f);
        Destroy(gameObject);
    }
}