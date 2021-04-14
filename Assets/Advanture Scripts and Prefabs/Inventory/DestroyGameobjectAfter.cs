using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobjectAfter : MonoBehaviour
{
    [SerializeField]
    private float destroyAfter;
    void Start()
    {
        StartCoroutine(DestroyGameobject());
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(destroyAfter);
        Destroy(gameObject);
    }
}
