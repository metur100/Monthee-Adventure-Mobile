using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManager>().StartDialogue(dialogue);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_Knight_Advanturer"))
        {
            TriggerDialogue();
        }
        //Destroy(gameObject);
    }
}
