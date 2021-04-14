using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarKnight : MonoBehaviour
{
    [SerializeField]
    private Image Bar;
    [SerializeField]
    private float updateExpFrame = 0.5f;

    private void Awake()
    {
        FindObjectOfType<ExpKnight>().OnExpPctChanged += HandleExpChanged;
    }
    private void HandleExpChanged(float pct)
    {
        StartCoroutine(ChangeToPct(pct));
    }
    private IEnumerator ChangeToPct(float pct)
    {
        float preChangePct = Bar.fillAmount;
        float elapsed = 0f;

        while (elapsed < updateExpFrame)
        {
            elapsed += Time.deltaTime;
            Bar.fillAmount = Mathf.Lerp(preChangePct, pct, elapsed / updateExpFrame);
            yield return null;
        }
        Bar.fillAmount = pct;
    }
}
