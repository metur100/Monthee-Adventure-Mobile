using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform respawnPoints;
    public GameObject playerPrefab;

    public CinemachineVirtualCameraBase cam;

    public void Awake()
    {
        instance = this;
    }
    public void Respawn ()
    {
        GameObject player = Instantiate(playerPrefab, respawnPoints.position, Quaternion.identity);
        cam.Follow = player.transform;
    }
}
