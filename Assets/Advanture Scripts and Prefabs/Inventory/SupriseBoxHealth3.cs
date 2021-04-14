using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SupriseBoxHealth3 : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    public event Action<float> OnHealthPctChanged = delegate { };
    public Animator animator;
    private int currentHealth;
    public GameObject deathEffect;
    public GameObject dropItem;

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
            FindObjectOfType<AudioManager>().Play("Chest_Destroyed");
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Instantiate(dropItem, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
    }
}
