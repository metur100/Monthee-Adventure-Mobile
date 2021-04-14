using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastingBarSpellNum : MonoBehaviour
{
    public Transform firePointFrostBall;
    public GameObject bulletPrefabFrostBall;
    public Animator animator;
    public Transform firePointFireBall;
    public GameObject bulletPrefabFireBall;
    public CanvasGroup canvasGroup;
    public Image frostBallAbility;
    public Image fireBallAbility;
    private Vector3 starPos;
    private Vector3 endPos;
    private Image castImage;
    private RectTransform castTransoform;
    private Spell frostBall = new Spell("Frost Ball", 0.5f, Color.blue);
    private Spell fireBall = new Spell("Fire Ball", 2f, Color.red);
    private bool isCasting;
    private float fadeSpeed = 1f;
    private float cooldownFrost = 2f;
    private float cooldownFire = 4f;
    private bool isCooldownFrost = false;
    private bool isCooldownFire = false;
    private float cooldownFrostBall = 0.5f;
    private float cooldownFireBall = 2f;

    // Start is called before the first frame update
    void Start()
    {
        frostBallAbility.fillAmount = 0;
        fireBallAbility.fillAmount = 0;
        isCasting = false;
        castTransoform = GetComponent<RectTransform>();
        castImage = GetComponent<Image>();
        endPos = castTransoform.position;
        starPos = new Vector3(castTransoform.position.x - castTransoform.rect.width, castTransoform.position.y, castTransoform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7) && isCooldownFrost == false)
        {
            isCooldownFrost = true;
            frostBallAbility.fillAmount = 1;
            StartCoroutine(CastSpell(frostBall));
            StartCoroutine(ShootFrostBall());
            FindObjectOfType<AudioManager>().Play("CastingFrostBall");
        }
        if (Input.GetKeyDown(KeyCode.Keypad9) && isCooldownFire == false)
        {
            isCooldownFire = true;
            fireBallAbility.fillAmount = 1;
            StartCoroutine(CastSpell(fireBall));
            StartCoroutine(ShootFireBall());
            FindObjectOfType<AudioManager>().Play("CastingFireBall");
        }
        if (isCooldownFrost)
        {
            frostBallAbility.fillAmount -= 1 / cooldownFrost * Time.deltaTime;
            if (frostBallAbility.fillAmount <= 0)
            {
                frostBallAbility.fillAmount = 0;
                isCooldownFrost = false;
            }
        }
        if (isCooldownFire)
        {
            fireBallAbility.fillAmount -= 1 / cooldownFire * Time.deltaTime;
            if (fireBallAbility.fillAmount <= 0)
            {
                fireBallAbility.fillAmount = 0;
                isCooldownFire = false;
            }
        }
    }

    private IEnumerator FadeOutCastingBar()
    {
        StopCoroutine("FadeInCastingBar");
        while (canvasGroup.alpha > 0f)
        {
            float newValue = fadeSpeed * Time.deltaTime;
            if ((canvasGroup.alpha - newValue) > 0f)
            {
                canvasGroup.alpha -= newValue;
            }
            else
            {
                canvasGroup.alpha = 0;
            }
            yield return null;
        }
    }
    private IEnumerator FadeInCastingBar()
    {
        StopCoroutine("FadeOutCastingBar");
        while (canvasGroup.alpha < 1f)
        {
            float newValue = fadeSpeed * Time.deltaTime;
            if ((canvasGroup.alpha + newValue) < 1)
            {
                canvasGroup.alpha += newValue;
            }
            else
            {
                canvasGroup.alpha = 1;
            }
            yield return null;
        }
    }
    private IEnumerator CastSpell(Spell spell)
    {
        if (!isCasting)
        {
            StartCoroutine("FadeInCastingBar");
            isCasting = true;
            castImage.color = spell.myColor;
            castTransoform.position = starPos;
            float timeLeft = Time.deltaTime;
            float rate = 1.0f / spell.myCastTime;
            float progress = 0.0f;

            while (progress <= 1.0)
            {
                castTransoform.position = Vector3.Lerp(starPos, endPos, progress);

                progress += rate * Time.deltaTime;

                timeLeft += Time.deltaTime;

                yield return null;
            }
            castTransoform.position = endPos;
            isCasting = false;
            StartCoroutine("FadeOutCastingBar");
        }
    }
    IEnumerator ShootFrostBall()
    {
        yield return new WaitForSeconds(cooldownFrostBall);
        Instantiate(bulletPrefabFrostBall, firePointFrostBall.position, firePointFrostBall.rotation);
        animator.SetTrigger("Throw");
    }
    IEnumerator ShootFireBall()
    {
        yield return new WaitForSeconds(cooldownFireBall);
        Instantiate(bulletPrefabFireBall, firePointFireBall.position, firePointFireBall.rotation);
        animator.SetTrigger("Throw");
    }
}
