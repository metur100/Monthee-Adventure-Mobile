using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyGameobject());
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
