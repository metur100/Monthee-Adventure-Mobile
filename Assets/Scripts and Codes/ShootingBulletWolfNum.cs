using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingBulletWolfNum : MonoBehaviour
{
    public Transform firePointBullet;
    public GameObject bulletPrefabWolf;
    public Animator animator;
    public Image shootingBulletImage;
    private float cooldownBulletWolf = 2f;
    private bool iscooldownBulletWolf = false;

    void Start()
    {
        shootingBulletImage.fillAmount = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2") && iscooldownBulletWolf == false)
        {
            iscooldownBulletWolf = true;
            shootingBulletImage.fillAmount = 1;
            ShootBullet();
            animator.SetTrigger("Throw");
            FindObjectOfType<AudioManager>().Play("ArrowHunter");
        }
        if (iscooldownBulletWolf)
        {
            shootingBulletImage.fillAmount -= 1 / cooldownBulletWolf * Time.deltaTime;
            if (shootingBulletImage.fillAmount <= 0)
            {
                shootingBulletImage.fillAmount = 0;
                iscooldownBulletWolf = false;
            }
        }
    }
    void ShootBullet()
    {
        Instantiate(bulletPrefabWolf, firePointBullet.position, firePointBullet.rotation);
    }
}
