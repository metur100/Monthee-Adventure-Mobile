using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogUpperCave : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea(3, 10)]
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject activateDialog;
    public GameObject activatePortal;
    public PlayerMovementAdvanturerKnight moveSpeed;
    public DashMoveButton dashMove;
    public GameObject continueButton;
    public GameObject activateTriggerCreatePlatform;
    private void Start()
    {
        StartCoroutine(Type());
    }
    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        FindObjectOfType<AudioManager>().Play("Next_Dialog");
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
        if (index == sentences.Length - 5)
        {
            activateTriggerCreatePlatform.SetActive(true);
        }
        if (index == sentences.Length - 3)
        {
            FindObjectOfType<AudioManager>().Play("MonD_CreatePlatform");
            activatePortal.SetActive(true);
        }
        if (index == sentences.Length - 1)
        {
            activateDialog.SetActive(false);
            activateTriggerCreatePlatform.SetActive(false);
            moveSpeed.normalMovementSpeed = 400f;
            dashMove.dashSpeed = 200f;
        }
    }
    public void SkipDialog()
    {
        FindObjectOfType<AudioManager>().Play("MonD_CreatePlatform");
        activateTriggerCreatePlatform.SetActive(true);
        activatePortal.SetActive(true);
        activateDialog.SetActive(false);
        //activateTriggerCreatePlatform.SetActive(false);
        moveSpeed.normalMovementSpeed = 400f;
        dashMove.dashSpeed = 200f;
    }
}
