using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAudioAfter : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 1f);
    }
}
