using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageReductionKnightAdvanturer : MonoBehaviour
{
    public Image damageRed;
    public Animator animator;
    private float dmgReductionDuration = 1f;
    private bool isCooldownDmgRed = false;
    private float DmgRedCooldown = 5f;
    private bool isBlock = false;
    void Start()
    {
        damageRed.fillAmount = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isCooldownDmgRed == false)
        {
            isCooldownDmgRed = true;
            damageRed.fillAmount = 1;
            StartCoroutine(DamageReductionDurationFrostB());
            FindObjectOfType<AudioManager>().Play("BlockedKnight");
        }
        if (isCooldownDmgRed)
        {
            damageRed.fillAmount -= 1 / DmgRedCooldown * Time.deltaTime;
            if (damageRed.fillAmount <= 0)
            {
                damageRed.fillAmount = 0;
                isCooldownDmgRed = false;
            }
        }
    }
    IEnumerator DamageReductionDurationFrostB()
    {
        Physics2D.IgnoreLayerCollision(11, 21, true);
        Physics2D.IgnoreLayerCollision(11, 22, true);
        isBlock = true;
        animator.SetBool("IsBlock", isBlock);
        yield return new WaitForSeconds(dmgReductionDuration);
        isBlock = false;
        animator.SetBool("IsBlock", isBlock);
        Physics2D.IgnoreLayerCollision(11, 21, false);
        Physics2D.IgnoreLayerCollision(11, 22, false);
    }
}
