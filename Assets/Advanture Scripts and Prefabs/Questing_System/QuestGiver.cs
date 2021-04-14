 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public PlayerKnightQuestManager player;
    public GameObject questWindow;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI experianceText;
    public GameObject questAcceptedTxt;
    public void OpenQuestWindow()
    {
        FindObjectOfType<AudioManager>().Play("Quest_Windows");
        questWindow.SetActive(true);
        titleText.text = quest.title;
        descriptionText.text = quest.description;
        experianceText.text = quest.experianceReward.ToString();
    }
    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        player.quest = quest;
        StartCoroutine(QuestAccepted());
    }
    IEnumerator QuestAccepted()
    {
        questAcceptedTxt.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        questAcceptedTxt.SetActive(false);
    }
}