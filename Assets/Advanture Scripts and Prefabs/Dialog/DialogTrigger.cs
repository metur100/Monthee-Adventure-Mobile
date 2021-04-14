using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public PlayerMovementAdvanturerKnight moveSpeed;
    public DashMoveButton dashMove;
    public GameObject triggerDialogStart;
    public GameObject triggerGreenPigDialog;
    public GameObject triggerBeforeFirstBoss;
    public GameObject triggerAfterFirstBoss;
    public GameObject activateDialogStart;
    public GameObject activateGreenPigDialog;
    public GameObject activateDialogBeforeFirstBoss;
    public GameObject activateDialogAfterFirstBoss;
    public GameObject doTheQuestFirst;
    public GameObject bossAndHealthUI;
    public AudioSource gameTheme;
    public AudioSource bossTheme;
    public GameObject activateTextSpawnBox;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MonD_NPC"))
        {
            activateDialogStart.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerDialogStart);
        }
        if (other.CompareTag("Dialog_GreenPig"))
        {
            gameTheme.Stop();
            bossTheme.Play();
            bossAndHealthUI.SetActive(true);
            activateGreenPigDialog.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerGreenPigDialog);
        }
        if (other.CompareTag("MonD_BeforeFirstBoss"))
        {
            activateDialogBeforeFirstBoss.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerBeforeFirstBoss);
        }
        if (other.CompareTag("DoTheQuestFirst"))
        {
            StartCoroutine(WaitTime());
        }
        if (other.CompareTag("MonD_AfterFirstBoss"))
        {
            activateDialogAfterFirstBoss.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            dashMove.dashSpeed = 0f;
            Destroy(triggerAfterFirstBoss);
        }
        if (other.CompareTag("Spawn_Box_Txt"))
        {
            StartCoroutine(SpawnBoxTextUI());
        }
    }
    IEnumerator WaitTime()
    {
        doTheQuestFirst.SetActive(true);
        yield return new WaitForSeconds(3f);
        doTheQuestFirst.SetActive(false);
    }
    IEnumerator SpawnBoxTextUI()
    {
        activateTextSpawnBox.SetActive(true);
        yield return new WaitForSeconds(5f);
        activateTextSpawnBox.SetActive(false);
    }
}
