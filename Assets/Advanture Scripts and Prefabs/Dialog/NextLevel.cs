using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public LevelLoader nextLevel;
    [SerializeField]
    private int buildLevelIndex;
    public MapLevelScript unlockLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player_Knight_Advanturer"))
        {
            unlockLevel.Pass();
            nextLevel.LoadScreenExample(buildLevelIndex);
        }
    }
}
