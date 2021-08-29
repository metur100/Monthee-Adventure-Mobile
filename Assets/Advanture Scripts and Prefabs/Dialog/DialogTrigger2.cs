using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger2 : MonoBehaviour
{
    public GameObject triggerStart;
    public GameObject activateDialogStart;
    public GameObject triggerGravityTip;
    public GameObject activateGravityTip;
    public GameObject triggerUpperCave;
    public GameObject activateDialogUpperCave;
    public GameObject triggerLowerCave;
    public GameObject activateDialogLowerCave;
    public GameObject triggerGhost;
    public GameObject activateDialogGhost;
    public GameObject triggerAfterGhost;
    public GameObject activateDialogAfterGhost;
    public PlayerMovementAdvanturerKnight moveSpeed;
    public DashMoveButton dashMove;
    public GameObject bossHealthAndUI;
    public AudioSource gameTheme;
    public AudioSource bossTheme;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dialog_Upper_Cave"))
        {
            activateDialogUpperCave.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerUpperCave);
        }
        if (collision.CompareTag("Dialog_Lower_Cave"))
        {
            activateDialogLowerCave.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerLowerCave);
        }
        if (collision.CompareTag("Dialog_Start"))
        {
            activateDialogStart.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerStart);
        }
        if (collision.CompareTag("Ghost_Dialog"))
        {
            gameTheme.Stop();
            bossTheme.Play();
            bossHealthAndUI.SetActive(true);
            activateDialogGhost.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerGhost);
        }
        if (collision.CompareTag("Dialog_After_Ghost"))
        {
            activateDialogAfterGhost.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerAfterGhost);
        }
        if (collision.CompareTag("Gravity_Tip"))
        {
            activateGravityTip.SetActive(true);
            Destroy(triggerGravityTip);
        }
    }
}
