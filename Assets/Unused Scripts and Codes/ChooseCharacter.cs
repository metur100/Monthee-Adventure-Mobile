using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseCharacter : MonoBehaviour
{
    Static_Variables player = new Static_Variables();
    void PickCharacters()
    {
        //do some fancy magic that lets the player pick their character, let's pretend we picked 7 //and 8
        player.lastChosenPlayer1 = 7;
        player.lastChosenPlayer2 = 8;
        //note that we don't need a reference to Static_Variables, as it's a public class that isn't monobehaviour
    }
}
