using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExpKnight : MonoBehaviour
{
    [SerializeField]
    private int maxExp;
    public event Action<float> OnExpPctChanged = delegate { };
    public GameObject levelReached;
    [SerializeField]
    public int currentExp;
    public GameObject hideExpBar;
    public HealthKnightAdvanturer maxH;
    public MeleePrefabKnightAdvanturer damageMeleeAttack;
    public FireBallKnight damageFireBall;
    private void Start()
    {
        if (currentExp == 0)
        {
            hideExpBar.SetActive(false);
        }
    }
    public void ModifyExp(int amount)
    {
        if (currentExp < maxExp)
        {
            hideExpBar.SetActive(true);
            currentExp += amount;
        }
        if (currentExp >= maxExp)
        {
            FindObjectOfType<AudioManager>().Play("LevelUp");
            TrackPlayerLevels.scoreValue += 1;
            currentExp = 0;
            levelReached.SetActive(true);
            maxH.maxHealth += 100;
            damageMeleeAttack.damageDoneMeleeAttack -= 10;
            damageFireBall.damageDoneFireB -= 10;
            maxH.ModifyHealth(maxH.maxHealth);
            StartCoroutine(DisableText());
        }
        float currentExpPct = (float)currentExp / (float)maxExp;
        OnExpPctChanged(currentExpPct);
    }
    IEnumerator DisableText()
    {
        yield return new WaitForSeconds(6f);
        levelReached.SetActive(false);
    }
}
