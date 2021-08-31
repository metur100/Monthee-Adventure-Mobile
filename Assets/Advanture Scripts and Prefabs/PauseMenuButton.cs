using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuButton : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pausedMenuUI;
    public GameObject settings;
    public GameObject resetLevel;
    public GameObject exitGame;
    public GameObject goToMainMenu;
    private bool executeGamePause;

    void Update()
    {
        if (executeGamePause)
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        executeGamePause = false;
    }
    public void Resume()
    {
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    void Pause()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void LoadLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Advanture2");
    }
    public void LoadLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Advanture");
    }
    public void LoadTutorial()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tutorial");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenSettings()
    {
        settings.SetActive(true);
    }
    public void ResetLevelPopUp()
    {
        resetLevel.SetActive(true);
    }
    public void ExitGamePopUp()
    {
        exitGame.SetActive(true);
    }
    public void GoMainMenuPopUp()
    {
        goToMainMenu.SetActive(true);
    }
    public void NoResetLevel()
    {
        resetLevel.SetActive(false);
    }
    public void NoExitGame()
    {
        exitGame.SetActive(false);
    }
    public void NoMainMenu()
    {
        goToMainMenu.SetActive(false);
    }
    public void CloseSettings()
    {
        settings.SetActive(false);
    }
    public void PauseTheGame()
    {
        executeGamePause = true;
    }
}
