using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogAfterGhost : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea(3, 10)]
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject activateDialog;
    public PlayerMovementAdvanturerKnight moveSpeed;
    public DashMoveButton dashMove;
    public GameObject continueButton;
    public GameObject activateCompletedGameUI;
    [SerializeField]
    AudioSource winSound;
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
        if (index == sentences.Length - 1)
        {
            winSound.Play();
            activateDialog.SetActive(false);
            moveSpeed.normalMovementSpeed = 400f;
            dashMove.dashSpeed = 200f;
            activateCompletedGameUI.SetActive(true);
        }
    }
    public void SkipDialog()
    {
        FindObjectOfType<AudioManager>().Play("Next_Dialog");
        winSound.Play();
        activateDialog.SetActive(false);
        moveSpeed.normalMovementSpeed = 500f;
        dashMove.dashSpeed = 300f;
        activateCompletedGameUI.SetActive(true);
    }
}
