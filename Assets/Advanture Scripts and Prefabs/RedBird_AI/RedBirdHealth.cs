using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RedBirdHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    public event Action<float> OnHealthPctChanged = delegate { };
    public Animator animator;
    [SerializeField]
    private int currentHealth;
    public GameObject deathEffect;
    public GameObject dropItem;
    private bool isDead;
    [SerializeField]
    Transform playerPosition;
    [SerializeField]
    private float distance;
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
        if (currentHealth <= 0 && !isDead)
        {
            isDead = true;
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Instantiate(dropItem, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
        FindObjectOfType<AudioManager>().Play("IsHurt_RedBird");
        animator.SetTrigger("IsHurt");
    }
    private void Update()
    {
        if (gameObject != null)
        {
            float distToPlayer = Vector2.Distance(transform.position, playerPosition.position);

            if (distToPlayer > distance && currentHealth < maxHealth)
            {
                ModifyHealth(80);
            }
        }
    }
}
