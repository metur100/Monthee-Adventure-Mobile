using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BubbleHolyKnight : MonoBehaviour
{
    public Image invulnerable;
    public Animator anim;
    private bool isCooldownInvuln = false;
    private float invulnerabelCooldown = 9f;
    private bool isBubble = false;
    private float bubbleDuration = 4f;

    // Start is called before the first frame update
    void Start()
    {
        invulnerable.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && isCooldownInvuln == false)
        {
            isCooldownInvuln = true;
            invulnerable.fillAmount = 1;
            StartCoroutine(GetInvulnerable());
            FindObjectOfType<AudioManager>().Play("BubblyHolyKnight");
        }
        if (isCooldownInvuln)
        {
            invulnerable.fillAmount -= 1 / invulnerabelCooldown * Time.deltaTime;
            if (invulnerable.fillAmount <= 0)
            {
                invulnerable.fillAmount = 0;
                isCooldownInvuln = false;
            }
        }
    }
    IEnumerator GetInvulnerable()
    {
        Physics2D.IgnoreLayerCollision(19, 17, true);
        Physics2D.IgnoreLayerCollision(19, 14, true);
        Physics2D.IgnoreLayerCollision(19, 18, true);
        Physics2D.IgnoreLayerCollision(19, 15, true);
        Physics2D.IgnoreLayerCollision(19, 16, true);
        Physics2D.IgnoreLayerCollision(19, 20, true);
        isBubble = true;
        anim.SetBool("isBubble", isBubble);
        yield return new WaitForSeconds(bubbleDuration);
        Physics2D.IgnoreLayerCollision(19, 17, false);
        Physics2D.IgnoreLayerCollision(19, 14, false);
        Physics2D.IgnoreLayerCollision(19, 18, false);
        Physics2D.IgnoreLayerCollision(19, 15, false);
        Physics2D.IgnoreLayerCollision(19, 16, false);
        Physics2D.IgnoreLayerCollision(19, 20, false);
        isBubble = false;
        anim.SetBool("isBubble", isBubble);
    }
}
