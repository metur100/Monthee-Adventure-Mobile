using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunHolyKnight : MonoBehaviour
{
    public Rigidbody2D rb;
    private PlayerMovementNinja mSpeedNinja;
    private PlayerMovementKnight mSpeedKnight;
    private PlayerMovementHunter mSpeedHunter;
    private PlayerMovementNinjaNum mSpeedNinjaNum;
    private PlayerMovementKnightNum mSpeedKnightNum;
    private PlayerMovementHunterNum mSpeedHunterNum;
    private PlayerMovementHolyKnightNum mSpeedHolyKnightNum;
    public BulletHunter bulletDealsNoDamage = new BulletHunter();
    public MeleePrefabKnight noDmgMeleeAttackKnight = new MeleePrefabKnight();
    public MeleePrefabKnightNum noDmgMeleeAttackKnightNum = new MeleePrefabKnightNum();
    public MeleePrefabHolyKnightNum noDmgMeleeAttackHolyKnightNum = new MeleePrefabHolyKnightNum();
    public FrostBall noDmgFrostBall = new FrostBall();
    public FireBall noDmgFireBall = new FireBall();
    private int bulletDealsNoDmg = 0;
    private int maxDamageFromBullet = -20;
    private int frostBallDealsNoDamage = 0;
    private int frostBallMaxDamage = -20;
    private int fireBallDealsNoDamage = 0;
    private int fireBallMaxDamage = -50;
    private int meleeAttackNoDmg = 0;
    private int meleeAttackMaxDmg = -20;
    private float durationOfStun = 3f;
    private float speedOfStun = 150f;
    private float destroyStun = 4f;
    void Start()
    {
        StartCoroutine(DestroyGameobject());
        rb.velocity = transform.right * speedOfStun;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player_Knight")
        {
            mSpeedKnight = other.gameObject.GetComponent<PlayerMovementKnight>();
            mSpeedKnight.CoroutineMoveIfTrapKnight();

            StartCoroutine(GetNoDamageFromMeleeAttackKnight());
        }
        if (other.gameObject.tag == "Player_Hunter")
        {
            StartCoroutine(GetNoDamageFromArrowHunter());
            mSpeedHunter = other.gameObject.GetComponent<PlayerMovementHunter>();
            mSpeedHunter.CoroutineMoveIfTrapHunter();
        }

        if (other.gameObject.tag == "Player_Ninja")
        {
            mSpeedNinja = other.gameObject.GetComponent<PlayerMovementNinja>();
            mSpeedNinja.CoroutineMoveIfTrapNinja();

            StartCoroutine(GetNoDamageFromFrostBall());
            StartCoroutine(GetNoDamageFromFireBall());
        }

        if (other.gameObject.tag == "Player_Ninja_Num")
        {
            mSpeedNinjaNum = other.gameObject.GetComponent<PlayerMovementNinjaNum>();
            mSpeedNinjaNum.CoroutineMoveIfTrapNinja();

            StartCoroutine(GetNoDamageFromFrostBall());
            StartCoroutine(GetNoDamageFromFireBall());
        }

        if (other.gameObject.tag == "Player_Knight_Num")
        {
            mSpeedKnightNum = other.gameObject.GetComponent<PlayerMovementKnightNum>();
            mSpeedKnightNum.CoroutineMoveIfTrapKnight();

            StartCoroutine(GetNoDamageFromMeleeAttackKnightNum());
        }
        if (other.gameObject.tag == "Player_Hunter_Num")
        {
            mSpeedHunterNum = other.gameObject.GetComponent<PlayerMovementHunterNum>();
            mSpeedHunterNum.CoroutineMoveIfTrapHunter();
            StartCoroutine(GetNoDamageFromArrowHunter());
        }
        if (other.gameObject.tag == "Player_HolyKnight_Num")
        {
            StartCoroutine(GetNoDamageFromMeleeAttackHolyKnight());

            mSpeedHolyKnightNum = other.gameObject.GetComponent<PlayerMovementHolyKnightNum>();
            mSpeedHolyKnightNum.CoroutineMoveIfTrapHolyKnight();
        }
    }
    IEnumerator GetNoDamageFromArrowHunter()
    {
        bulletDealsNoDamage.damageDoneBullet = bulletDealsNoDmg;
        yield return new WaitForSeconds(durationOfStun);
        bulletDealsNoDamage.damageDoneBullet = maxDamageFromBullet;
    }
    IEnumerator GetNoDamageFromMeleeAttackKnight()
    {
        noDmgMeleeAttackKnight.damageDoneMeleeAttack = meleeAttackNoDmg;
        yield return new WaitForSeconds(durationOfStun);
        noDmgMeleeAttackKnight.damageDoneMeleeAttack = meleeAttackMaxDmg;
    }
    IEnumerator GetNoDamageFromMeleeAttackKnightNum()
    {
        noDmgMeleeAttackKnightNum.damageDoneMeleeAttack = meleeAttackNoDmg;
        yield return new WaitForSeconds(durationOfStun);
        noDmgMeleeAttackKnightNum.damageDoneMeleeAttack = meleeAttackMaxDmg;
    }
    IEnumerator GetNoDamageFromMeleeAttackHolyKnight()
    {
        noDmgMeleeAttackHolyKnightNum.damageDoneMeleeAttack = meleeAttackNoDmg;
        yield return new WaitForSeconds(durationOfStun);
        noDmgMeleeAttackHolyKnightNum.damageDoneMeleeAttack = meleeAttackMaxDmg;
    }
    IEnumerator GetNoDamageFromFrostBall()
    {
        noDmgFrostBall.damageDoneFrostB = frostBallDealsNoDamage;
        yield return new WaitForSeconds(durationOfStun);
        noDmgFrostBall.damageDoneFrostB = frostBallMaxDamage;
    }
    IEnumerator GetNoDamageFromFireBall()
    {
        noDmgFireBall.damageDoneFireB = fireBallDealsNoDamage;
        yield return new WaitForSeconds(durationOfStun);
        noDmgFireBall.damageDoneFireB = fireBallMaxDamage;
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(3.2f);
        Destroy(gameObject);
    }
}
