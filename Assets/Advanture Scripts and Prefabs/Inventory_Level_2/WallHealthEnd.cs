using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WallHealthEnd : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 10;
    public event Action<float> OnHealthPctChanged = delegate { };
    [SerializeField]
    public int currentHealth;
    //private float delay = 1f;
    public GameObject deathEffect;
    public GameObject deactivateText;
    private void OnEnable()
    {
        currentHealth = maxHealth;
    }
    public void ModifyHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            deactivateText.SetActive(false);
            //FindObjectOfType<AudioManager>().Play("Death");
            //activateDeathCount.onClick.Invoke();
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject/*this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length*/);

        }
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
        //FindObjectOfType<AudioManager>().Play("Hurt");
    }
}
