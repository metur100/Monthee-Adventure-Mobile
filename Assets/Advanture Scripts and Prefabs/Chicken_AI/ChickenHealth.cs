using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using EZCameraShake;

public class ChickenHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    public event Action<float> OnHealthPctChanged = delegate { };
    public Animator animator;
    [SerializeField]
    private int currentHealth;
    public GameObject deathEffect;
    public GameObject finalAttack;
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
            CameraShaker.Instance.ShakeOnce(0.4f, 7f, 2f, 2f);
            StartCoroutine(WaitTime());
        }
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
        FindObjectOfType<AudioManager>().Play("IsHurt_Chicken");
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
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Instantiate(finalAttack, transform.position, Quaternion.identity);
        Instantiate(dropItem, transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("Explode_Effect");
        Destroy(gameObject);
    }
}
