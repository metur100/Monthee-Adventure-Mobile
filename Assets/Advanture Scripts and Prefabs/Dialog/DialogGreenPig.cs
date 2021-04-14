using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogGreenPig : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea(3, 10)]
    public string[] sentences;
    private int index;
    public float typingSpeed;
    [SerializeField]
    private GameObject activateDialog;
    [SerializeField]
    private GameObject activateWallAndEnemies;
    [SerializeField]
    private PlayerMovementAdvanturerKnight moveSpeed;
    [SerializeField]
    private GameObject continueButton;
    [SerializeField]
    private GameObject triggerWall;
    [SerializeField]
    Transform positionWall;
    [SerializeField]
    private GreenPigChaseAndAttack chaseDistance;
    [SerializeField]
    private GameObject shield;
    public DashMoveButton dashMove;
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
            activateWallAndEnemies.SetActive(true);
            Instantiate(triggerWall, positionWall.position, Quaternion.identity);
            activateDialog.SetActive(false);
            moveSpeed.normalMovementSpeed = 400f;
            chaseDistance.agroRange = 500f;
            dashMove.dashSpeed = 200f;
            Destroy(shield);
        }
    }
    public void SkipDialog()
    {
        FindObjectOfType<AudioManager>().Play("Next_Dialog");
        activateWallAndEnemies.SetActive(true);
        Instantiate(triggerWall, positionWall.position, Quaternion.identity);
        activateDialog.SetActive(false);
        moveSpeed.normalMovementSpeed = 400f;
        chaseDistance.agroRange = 500f;
        dashMove.dashSpeed = 200f;
        Destroy(shield);
    }
}
