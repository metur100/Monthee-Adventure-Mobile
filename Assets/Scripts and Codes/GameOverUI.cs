using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Exit ()
    {
        Application.Quit();
    }
    public void CharacterSelection()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
    public void GameScene()
    {
        SceneManager.LoadScene("Main");
    }
    public void mainManuBack ()
    {
        SceneManager.LoadScene("Menu");
    }
}
