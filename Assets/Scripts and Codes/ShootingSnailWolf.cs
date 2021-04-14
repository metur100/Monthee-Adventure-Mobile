using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingSnailWolf : MonoBehaviour
{
    public Transform firePointSnail;
    public GameObject snailPrefab;
    public Animator animator;
    public Image shootingSnailImage;
    private float cooldownSnail = 2f;
    private bool iscooldownSnail = false;

    void Start()
    {
        shootingSnailImage.fillAmount = 0;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2") && iscooldownSnail == false)
        {
            iscooldownSnail = true;
            shootingSnailImage.fillAmount = 1;
            ShootBullet();
            animator.SetTrigger("Throw");
            //FindObjectOfType<AudioManager>().Play("ArrowHunter");
        }
        if (iscooldownSnail)
        {
            shootingSnailImage.fillAmount -= 1 / cooldownSnail * Time.deltaTime;
            if (shootingSnailImage.fillAmount <= 0)
            {
                shootingSnailImage.fillAmount = 0;
                iscooldownSnail = false;
            }
        }
    }
    void ShootBullet()
    {
        Instantiate(snailPrefab, firePointSnail.position, firePointSnail.rotation);
    }
}
