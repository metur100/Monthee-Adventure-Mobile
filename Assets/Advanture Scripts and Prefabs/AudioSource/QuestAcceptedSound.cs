using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestAcceptedSound : MonoBehaviour
{
    [SerializeField]
    private GameObject questAccepted;
    [SerializeField]
    private GameObject backpackButtonClick;
    [SerializeField]
    private GameObject questButtonClick;
    public void QuestSoundAccepted()
    {
        Instantiate(questAccepted, transform.position, transform.rotation);
    }
    public void BackpackButtonClick()
    {
        Instantiate(backpackButtonClick, transform.position, transform.rotation);
    }
    public void QuestkButtonClick()
    {
        Instantiate(questButtonClick, transform.position, transform.rotation);
    }
}
