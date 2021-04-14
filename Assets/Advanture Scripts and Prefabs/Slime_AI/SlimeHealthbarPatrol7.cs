using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeHealthbarPatrol7 : MonoBehaviour
{
    [SerializeField]
    private Image Bar;
    [SerializeField]
    private float updateHealtbarFrame = 0.5f;

    private void Awake()
    {
        FindObjectOfType<SlimeHealthPatrol7>().OnHealthPctChanged += HandleHealthChanged;
    }
    private void HandleHealthChanged(float pct)
    {
        StartCoroutine(ChangeToPct(pct));
    }
    private IEnumerator ChangeToPct(float pct)
    {
        float preChangePct = Bar.fillAmount;
        float elapsed = 0f;

        while (elapsed < updateHealtbarFrame)
        {
            elapsed += Time.deltaTime;
            Bar.fillAmount = Mathf.Lerp(preChangePct, pct, elapsed / updateHealtbarFrame);
            yield return null;
        }
        Bar.fillAmount = pct;
    }
}
