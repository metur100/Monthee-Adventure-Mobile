using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayeDodgeAnimation : MonoBehaviour
{
    Renderer rend;
    Color c;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        c = rend.material.color;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dodge_Layer"))
        {
            StartCoroutine(TemporalInvulnerability());          
        }
    }
    IEnumerator TemporalInvulnerability()
    {
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(5f);
        c.a = 1f;
        rend.material.color = c;
    }
}
