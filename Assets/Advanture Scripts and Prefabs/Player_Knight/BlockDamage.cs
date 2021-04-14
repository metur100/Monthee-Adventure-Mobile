using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlockDamage : MonoBehaviour
{
    public Transform firePointBlock;
    public GameObject blockPrefab;
    public Animator animator;
    public Image shootingBlock;
    private readonly float cooldownBlock = 1.5f;
    private bool isCooldownBlock = false;

    void Start()
    {
        shootingBlock.fillAmount = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isCooldownBlock == false)
        {
            isCooldownBlock = true;
            shootingBlock.fillAmount = 1;
            Instantiate(blockPrefab, firePointBlock.position, firePointBlock.rotation);
            animator.SetTrigger("IsBlocking");
            FindObjectOfType<AudioManager>().Play("BlockedKnight");
        }
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
}
