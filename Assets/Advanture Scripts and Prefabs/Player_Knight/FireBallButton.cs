using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class FireBallButton : MonoBehaviour
{
    public Transform firePointBullet;
    public GameObject bulletPrefab;
    public Animator animator;
    public Image shootingBullet;
    private readonly float cooldownBullet = 1.5f;
    private bool isCooldownBullet = false;
    private bool isPressed = false;

    void Start()
    {
        shootingBullet.fillAmount = 0;
    }
    void Update()
    {
        if (isPressed && isCooldownBullet == false)
        {         
            isCooldownBullet = true;
            shootingBullet.fillAmount = 1;
            StartCoroutine(ShootFireBall());
            animator.SetTrigger("Fire");
            FindObjectOfType<AudioManager>().Play("FireBallKnight");
        }
        isPressed = false;
        if (isCooldownBullet)
        {
            shootingBullet.fillAmount -= 1 / cooldownBullet * Time.deltaTime;
            if (shootingBullet.fillAmount <= 0)
            {
                shootingBullet.fillAmount = 0;
                isCooldownBullet = false;
            }
        }
    }
    IEnumerator ShootFireBall()
    {
        yield return new WaitForSeconds(0.67f);
        Instantiate(bulletPrefab, firePointBullet.position, firePointBullet.rotation);
        CameraShaker.Instance.ShakeOnce(.8f, .5f, 0.1f, 0.2f);
    }
    public void Execute()
    {
        isPressed = true;
    }
}
