using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverAdvanture : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void mainManuBack()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LastCheckPoint()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
