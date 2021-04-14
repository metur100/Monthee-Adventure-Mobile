using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ConfirmMenu : MonoBehaviour
{
    public CharacterSelection character = new CharacterSelection();
    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", character.index);
        SceneManager.LoadScene("Advanture");
    }
}
