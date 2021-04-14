using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeDamage : MonoBehaviour
{
    public Animator animator;
    private readonly float dmgReductionDuration = 5f;
    private bool isDodge = false;
    public ParticleSystem effect;
    public Transform player;
    public GameObject activate;
    private void Start()
    {
        Physics2D.IgnoreLayerCollision(11, 21, false);
        Physics2D.IgnoreLayerCollision(11, 22, false);
        player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
    }
    IEnumerator DodgeAllDamage()
    {
        Physics2D.IgnoreLayerCollision(11, 21, true);
        Physics2D.IgnoreLayerCollision(11, 22, true);
        isDodge = true;
        animator.SetBool("IsDodge", isDodge);
        yield return new WaitForSeconds(dmgReductionDuration);
        isDodge = false;
        animator.SetBool("IsDodge", isDodge);
        Physics2D.IgnoreLayerCollision(11, 21, false);
        Physics2D.IgnoreLayerCollision(11, 22, false);
        Destroy(gameObject);
    }
    public void Use()
    {
        FindObjectOfType<AudioManager>().Play("Dodge_Layer");
        effect.Play();
        Instantiate(activate, player.transform.position, Quaternion.identity);
        StartCoroutine(DodgeAllDamage());   
    }
}
