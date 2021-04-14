using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfirmCharacter : MonoBehaviour
{
    public CharacterSelection character = new CharacterSelection();
    public CharacterSelection2 character2 = new CharacterSelection2();
    public BattlegroundSelection bg = new BattlegroundSelection();

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", character.index);
        PlayerPrefs.SetInt("CharacterSelected2", character2.index);
        PlayerPrefs.SetInt("BGSelected", bg.index);
        SceneManager.LoadScene("Arena");

        //if (character.index == 0 && character2.index == 1 || character.index == 1 && character2.index == 0)
        //{
        //    SceneManager.LoadScene("Main");
        //}
        //else if (character.index == 1 && character2.index == 2 || character.index == 2 && character2.index == 1)
        //{
        //    SceneManager.LoadScene("Main2");
        //}
        //else if (character.index == 0 && character2.index == 2 || character.index == 2 && character2.index == 0)
        //{
        //    SceneManager.LoadScene("Main3");
        //}
    }
}