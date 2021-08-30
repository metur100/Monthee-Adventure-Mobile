using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlockDamageButton : MonoBehaviour
{
    public Transform firePointBlock;
    public GameObject blockPrefab;
    public Animator animator;
    public Image shootingBlock;
    private readonly float cooldownBlock = 3f;
    private bool isCooldownBlock = false;
    private bool isPressed;

    void Start()
    {
        shootingBlock.fillAmount = 0;
    }
    void Update()
    {
        if (isPressed && isCooldownBlock == false)
        {
            isCooldownBlock = true;
            shootingBlock.fillAmount = 1;
            Instantiate(blockPrefab, firePointBlock.position, firePointBlock.rotation);
            animator.SetTrigger("IsBlocking");
            FindObjectOfType<AudioManager>().Play("BlockedKnight");
        }
        isPressed = false;
        if (isCooldownBlock)
        {
            shootingBlock.fillAmount -= 1 / cooldownBlock * Time.deltaTime;
            if (shootingBlock.fillAmount <= 0)
            {
                shootingBlock.fillAmount = 0;
                isCooldownBlock = false;
            }
        }
    }
    public void Execute()
    {
        isPressed = true;
    }
}
