using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableHintText : MonoBehaviour
{
    public GameObject hintTxt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_Knight_Advanturer"))
        {
            StartCoroutine(DisableTxt());
        }
    }
    IEnumerator DisableTxt()
    {
        hintTxt.SetActive(true);
        yield return new WaitForSeconds(15f);
        hintTxt.SetActive(false);
        Destroy(gameObject);
    }
}
