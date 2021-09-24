using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    public Animator animator;
    public void PlayJumpAnim()
    {
        animator.SetBool("JumpAnim", true);
    }
    public void StopJumpAnim()
    {
        animator.SetBool("JumpAnim", false);
    }
}
