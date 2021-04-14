using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageReduction : MonoBehaviour
{
    public Image damageRed;
    public Animator animator;
    public FrostBall frostBallDamage = new FrostBall();
    public FireBall fireBallDamage = new FireBall();
    public BulletHunter bulletHunterDamage = new BulletHunter();   
    public MeleePrefabHolyKnight meleeAttackDamageHolyKnight = new MeleePrefabHolyKnight();
    public MeleePrefabHolyKnightNum meleeAttackDamageHolyKnightNum = new MeleePrefabHolyKnightNum();
    public MeleePrefabKnightNum meleeAttackDamageNum = new MeleePrefabKnightNum();
    private int damageReductionFrostB = 0;
    private int damageReductionFireB = 0;
    private int damageReductionBulletHunt = 0;
    private int damageReductionMeleeAttackHolyKnight = 0;
    private int damageReductionMeleeAttackHolyKnightNum = 0;
    private int damageReductionMeleeAttack = 0;
    private int damageReductionMeleeAttackNum = 0;
    private int normalFrostBDmg = -20;
    private int normalFireBDmg = -50;
    private int normalBulletDamage = -20;
    private int normalMeleeAttackDamageHolyKnight = -20;
    private int normalMeleeAttackDamageHolyKnightNum = -20;
    private int normalMeleeAttackDamage = -20;
    private int normalMeleeAttackDamageNum = -20;
    private float dmgReductionDuration = 1f;
    private bool isCooldownDmgRed = false;
    private float DmgRedCooldown = 2f;
    private bool isBlock = false;
    //Start is called before the first frame update
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
        frostBallDamage.damageDoneFrostB = damageReductionFrostB;
        fireBallDamage.damageDoneFireB = damageReductionFireB;
        bulletHunterDamage.damageDoneBullet = damageReductionBulletHunt;
        meleeAttackDamageHolyKnight.damageDoneMeleeAttack = damageReductionMeleeAttackHolyKnight;
        meleeAttackDamageNum.damageDoneMeleeAttack = damageReductionMeleeAttackNum;
        meleeAttackDamageHolyKnightNum.damageDoneMeleeAttack = damageReductionMeleeAttackHolyKnightNum;
        isBlock = true;
        animator.SetBool("IsBlock", isBlock);
        yield return new WaitForSeconds(dmgReductionDuration);
        isBlock = false;
        animator.SetBool("IsBlock", isBlock);
        frostBallDamage.damageDoneFrostB = normalFrostBDmg;
        fireBallDamage.damageDoneFireB = normalFireBDmg;
        bulletHunterDamage.damageDoneBullet = normalBulletDamage;
        meleeAttackDamageHolyKnight.damageDoneMeleeAttack = normalMeleeAttackDamageHolyKnight;
        meleeAttackDamageNum.damageDoneMeleeAttack = normalMeleeAttackDamageNum;
        meleeAttackDamageHolyKnightNum.damageDoneMeleeAttack = normalMeleeAttackDamageHolyKnightNum;
    }
}
