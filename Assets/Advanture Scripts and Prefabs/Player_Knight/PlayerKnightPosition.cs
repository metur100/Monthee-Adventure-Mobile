using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKnightPosition : MonoBehaviour
{
    //private GameMaster gm;
    public GameObject gameSaved;
    public GameObject gameLoaded;
    //void Start()
    //{
    //    gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    //    transform.position = gm.lastChackPointPos;
    //}
    public void SavePlayer()
    {
        gameSaved.SetActive(true);
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        gameLoaded.SetActive(true);
        PlayerData data = SaveSystem.LoadPlayer();
        Vector2 position;

        position.x = data.position[0];
        position.y = data.position[1];
        transform.position = position;
    }
}
