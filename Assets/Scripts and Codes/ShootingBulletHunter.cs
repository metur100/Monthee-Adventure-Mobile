using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingBulletHunter : MonoBehaviour
{
    public Transform firePointBullet;
    public GameObject bulletPrefab;
    public Transform firePointTrap;
    public GameObject trapPrefab;
    public Animator animator;
    public Image shootingBullet;
    public Image shootingTrap;
    private float cooldownBullet = 2f;
    private bool isCooldownBullet = false;
    private float cooldownTrap = 2f;
    private bool isCooldownTrap = false;

    void Start()
    {
        shootingBullet.fillAmount = 0;
        shootingTrap.fillAmount = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && isCooldownBullet == false)
        {
            isCooldownBullet = true;
            shootingBullet.fillAmount = 1;
            ShootBullet();
            animator.SetTrigger("Throw");
            FindObjectOfType<AudioManager>().Play("ArrowHunter");
        }
        if (isCooldownBullet)
        {
            shootingBullet.fillAmount -= 1 / cooldownBullet * Time.deltaTime;
            if (shootingBullet.fillAmount <= 0)
            {
                shootingBullet.fillAmount = 0;
                isCooldownBullet = false;
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire2") && isCooldownTrap == false)
            {
                isCooldownTrap = true;
                shootingTrap.fillAmount = 1;
                ShootTrap();
                animator.SetTrigger("Throw");
                FindObjectOfType<AudioManager>().Play("TrapHunter");
            }
            if (isCooldownTrap)
            {
                shootingTrap.fillAmount -= 1 / cooldownTrap * Time.deltaTime;
                if (shootingTrap.fillAmount <= 0)
                {
                    shootingTrap.fillAmount = 0;
                    isCooldownTrap = false;
                }
            }
        }
    }
    void ShootBullet()
    {
        Instantiate(bulletPrefab, firePointBullet.position, firePointBullet.rotation);
    }
    void ShootTrap()
    {
        Instantiate(trapPrefab, firePointTrap.position, firePointTrap.rotation);
    }
}
