using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlantHealth2 : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 200;
    public event Action<float> OnHealthPctChanged = delegate { };
    public Animator animator;
    [SerializeField]
    public int currentHealth;
    //private float delay = 1f;
    public GameObject deathEffect;
    //public GameObject bloodSplash;
    //public GameObject dropItem;
    //public Button activateDeathCount;
    private void OnEnable()
    {
        currentHealth = maxHealth;
        //current = GetComponent<QuestGoal>();
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
            //FindObjectOfType<AudioManager>().Play("Death");
            //activateDeathCount.onClick.Invoke();
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            //Instantiate(bloodSplash, transform.position, Quaternion.identity);
            //Instantiate(dropItem, transform.position, Quaternion.identity);
            Destroy(gameObject/*this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length*/);

        }
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
        //FindObjectOfType<AudioManager>().Play("Hurt");
        animator.SetTrigger("IsHurt");
    }
}
