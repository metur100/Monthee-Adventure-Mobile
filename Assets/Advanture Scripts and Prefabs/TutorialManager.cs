using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject skipTutorial;
    public GameObject playGame;

    public Joystick joystick;
    private bool bagButton;
    private bool questButton;
    private bool blockButton;
    private bool fireButton;
    private bool dashButton;
    private bool meleeButton;
    private bool pauseGameButton;

    void Update()
    {
        for(int i = 0; i < popUps.Length; i++)
        {
            if(i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }
        if (popUpIndex == 1)
        {
            if (joystick.Horizontal >= 0.2f || joystick.Horizontal <= -0.2f)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 2)
        {
            float verticalMove = joystick.Vertical;
            if (verticalMove >= .5f)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 3)
        {
            if (questButton)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 5)
        {
            if (bagButton)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 0 || popUpIndex == 6 || popUpIndex == 4
            || popUpIndex == 7 || popUpIndex == 8)
        {
            if (Input.anyKeyDown)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 9)
        {
            if (meleeButton)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 10)
        {
            if (dashButton)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 11)
        {
            if (fireButton)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 12)
        {
            if (blockButton)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 13)
        {
            if (pauseGameButton)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 14)
        {
            skipTutorial.SetActive(false);
            playGame.SetActive(true);
        }
    }
    public void BagButton()
    {
        bagButton = true;
    }
    public void QuestButton()
    {
        questButton = true;
    }
    public void MeleeButton()
    {
        meleeButton = true;
    }
    public void DashButton()
    {
        dashButton = true;
    }
    public void FireBallButton()
    {
        fireButton = true;
    }
    public void BlockButton()
    {
        blockButton = true;
    }
    public void PauseGame()
    {
        pauseGameButton = true;
    }
}
