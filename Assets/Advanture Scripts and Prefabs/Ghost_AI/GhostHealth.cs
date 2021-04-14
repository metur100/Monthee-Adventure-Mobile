using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;

public class GhostHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    public event Action<float> OnHealthPctChanged = delegate { };
    public Animator animator;
    [SerializeField]
    private int currentHealth;
    public GameObject deathEffect;
    public GameObject activateBotLoopAttack;
    SpriteRenderer spriteColor;
    public GhostShootingFollowRetreat ghostAI;
    public GameObject activateTriggerAfterBoss;
    public GameObject killSmallGhosts;
    public GameObject botLoop;
    void Start()
    {
        spriteColor = GetComponent<SpriteRenderer>();
    }
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
        if (currentHealth < 150)
        {
            CameraShaker.Instance.ShakeOnce(0.2f, 5f, 2f, 2f);
            spriteColor.color = new Color(255, 0, 0, 255);
            ghostAI.startTimeBtwShots = 1;
            ghostAI.speed = 80f;
            activateBotLoopAttack.SetActive(true);
        }
        if (currentHealth < 0)
        {
            FindObjectOfType<AudioManager>().Play("Ghost_Dead");
            Destroy(botLoop);
            CameraShaker.Instance.ShakeOnce(0.4f, 10f, 2f, 2f);
            StartCoroutine(WaitTime());
        }
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
        FindObjectOfType<AudioManager>().Play("IsHurt_Ghost");
        animator.SetTrigger("IsHurt");
    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Instantiate(killSmallGhosts, transform.position, Quaternion.identity); 
        activateTriggerAfterBoss.SetActive(true);
        Destroy(gameObject);
    }
}
