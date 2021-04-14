using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetZeroGravity : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= .5f;
        }
    }
}
