using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingStunHolyKnight : MonoBehaviour
{
    public Transform firePointStun;
    public GameObject stunPrefab;
    public Animator animator;
    public Image shootingStun;
    private float cooldownStun = 2f;
    private bool iscooldownStun = false;
    private bool isStun = false;
    private bool canShoot;

    void Start()
    {
        shootingStun.fillAmount = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("StunHolyKnight") && iscooldownStun == false )
        {
            iscooldownStun = true;
            shootingStun.fillAmount = 1;
            FindObjectOfType<AudioManager>().Play("StunHolyKnight");
            StartCoroutine(DelyOnShooting());
        }
        if (iscooldownStun)
        {
            shootingStun.fillAmount -= 1 / cooldownStun * Time.deltaTime;
            if (shootingStun.fillAmount <= 0)
            {
                shootingStun.fillAmount = 0;
                iscooldownStun = false;
            }
        }
    }
    void ShootBullet()
    {
        if(canShoot)
        Instantiate(stunPrefab, firePointStun.position, firePointStun.rotation);
    }
    IEnumerator DelyOnShooting()
    {
        canShoot = false;
        ShootBullet();
        isStun = true;
        animator.SetBool("IsStun", isStun);
        yield return new WaitForSeconds(0.55f);
        canShoot = true;
        ShootBullet();
        isStun = false;
        animator.SetBool("IsStun", isStun);
    }
}
