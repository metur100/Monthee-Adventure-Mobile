using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItems : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    private bool isTriggered;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_Knight_Advanturer") && !isTriggered)
        {
            isTriggered = true;
            FindObjectOfType<AudioManager>().Play("PickUp_Item");
            // spawn the sun button at the first available inventory slot ! 
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                { // check whether the slot is EMPTY
                    //Instantiate(effect, transform.position, Quaternion.identity);
                    inventory.isFull[i] = true; // makes sure that the slot is now considered FULL
                    Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    Destroy(gameObject);
                    break;
                }
            }
        }
        StartCoroutine(TriggerIsFalse());
    }
    IEnumerator TriggerIsFalse()
    {
        yield return new WaitForSeconds(1f);
        isTriggered = false;
    }
}
