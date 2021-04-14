using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public void backButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
