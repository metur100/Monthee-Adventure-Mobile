using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void CharacterSelection()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
    public void PlayAdvanture()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Advanture");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Levels()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Levels");
    }
}
