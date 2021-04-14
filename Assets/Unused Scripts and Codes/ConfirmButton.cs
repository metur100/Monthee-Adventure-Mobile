using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ConfirmButton : MonoBehaviour
{
    private bool isConfirmed = false;
    public CharacterSelection player1 = new CharacterSelection();
    //public SelectCharacter player2 = new SelectCharacter();
    public GameObject selectedButton;

    public void loadSceneWithChars ()
    {
        if (EventSystem.current == selectedButton)
        {
            Debug.Log(this.selectedButton.name + "was selected");
            isConfirmed = true;
            SceneManager.LoadScene("Main");
        }
        else
        {
            isConfirmed = false;
        }
    }
}
