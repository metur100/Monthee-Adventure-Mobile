using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    public Animator anim;
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            anim.SetBool("IsFlying", true);
            transform.localScale = new Vector2(-8f, 8f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            anim.SetBool("IsFlying", true);
            transform.localScale = new Vector2(8f, 8f);
        }
    }
}
