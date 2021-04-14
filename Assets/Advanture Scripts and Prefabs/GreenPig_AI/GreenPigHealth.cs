using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;

public class GreenPigHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    public event Action<float> OnHealthPctChanged = delegate { };
    public Animator animator;
    [SerializeField]
    public int currentHealth;
    public GameObject deathEffect;
    public GameObject destroyWallAndEnemies;
    public GameObject activateMonD;
    public GameObject movingPlatforms;
    public GameObject effectDestroinyMovingPlatform;
    private bool isEffectTriggered;
    [SerializeField]
    Transform posEffectDestroyMovPlatform;
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
        if (currentHealth <= 250 && !isEffectTriggered)
        {
            CameraShaker.Instance.ShakeOnce(0.3f, 10f, 1f, 1f);
            Instantiate(effectDestroinyMovingPlatform, transform.position, Quaternion.identity);
            isEffectTriggered = true;
            GetComponent<Boss>().enabled = true;
            GetComponent<Animator>().enabled = true;
            Destroy(movingPlatforms);
        }
        if (currentHealth < 0)
        {
            CameraShaker.Instance.ShakeOnce(0.4f, 10f, 2f, 2f);
            StartCoroutine(WaitTime());
        }
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
        FindObjectOfType<AudioManager>().Play("IsHurt_GreenPig");
        animator.SetTrigger("IsHurt");
    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(destroyWallAndEnemies);
        activateMonD.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Explode_Effect");
        Destroy(gameObject);
    }
}
