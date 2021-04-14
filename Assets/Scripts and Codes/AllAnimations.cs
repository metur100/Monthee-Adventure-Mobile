using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllAnimations : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        animator.SetBool("AllAnimations", true);
    }
}
