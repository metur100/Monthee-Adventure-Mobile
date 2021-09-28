using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUIButton : MonoBehaviour
{
    public GameObject questUI;
    public void ActivateUI()
    {
        questUI.SetActive(true);
    }
    public void DeactivateUI()
    {
        questUI.SetActive(false);
    }
}
