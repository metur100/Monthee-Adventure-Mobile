using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject[] player1;
    public GameObject[] player2;
    void Start()
    {
        if (PlayerPrefs.GetInt ("SellectedCharacter") == 0 && PlayerPrefs.GetInt("SellectedCharacter2") == 1)
        {
            Instantiate (player1 [(0)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(1)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 0 && PlayerPrefs.GetInt("SellectedCharacter2") == 0)
        {
            Instantiate(player1[(0)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(0)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 1 && PlayerPrefs.GetInt("SellectedCharacter2") == 1)
        {
            Instantiate(player1[(1)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(1)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 2 && PlayerPrefs.GetInt("SellectedCharacter2") == 2)
        {
            Instantiate(player1[(2)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(2)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 1 && PlayerPrefs.GetInt("SellectedCharacter2") == 0)
        {
            Instantiate(player1[(1)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(0)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 0 && PlayerPrefs.GetInt("SellectedCharacter2") == 2)
        {
            Instantiate(player1[(0)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(2)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 2 && PlayerPrefs.GetInt("SellectedCharacter2") == 0)
        {
            Instantiate(player1[(2)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(0)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 1 && PlayerPrefs.GetInt("SellectedCharacter2") == 2)
        {
            Instantiate(player1[(1)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(2)], Vector2.zero, Quaternion.identity);
        }
        else if (PlayerPrefs.GetInt("SellectedCharacter") == 2 && PlayerPrefs.GetInt("SellectedCharacter2") == 1)
        {
            Instantiate(player1[(2)], Vector2.zero, Quaternion.identity);
            Instantiate(player2[(1)], Vector2.zero, Quaternion.identity);
        }
    }
}
