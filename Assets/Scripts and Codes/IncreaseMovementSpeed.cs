using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMovementSpeed : MonoBehaviour
{
    private PlayerMovementHolyKnight movementSpeed = new PlayerMovementHolyKnight();
    public Animator animator;
    public float incraseMovementSpeed = 140f;
    private float speedOverTimeDuration = 3f;
    public float normalMoveSpeed = 70f;
    private bool isSpeeding = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(IncreasedMovementSpeed());
        }
    }
    IEnumerator IncreasedMovementSpeed()
    {
        movementSpeed.normalMovementSpeed = incraseMovementSpeed;
        isSpeeding = true;
        animator.SetBool("IsRunning", isSpeeding);
        yield return new WaitForSeconds(speedOverTimeDuration);
        movementSpeed.normalMovementSpeed = normalMoveSpeed;
        isSpeeding = false;
        animator.SetBool("IsRunning", isSpeeding);
    }
}
