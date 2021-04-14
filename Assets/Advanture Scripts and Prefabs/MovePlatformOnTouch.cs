using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformOnTouch : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;

    private bool moving;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player_Knight_Advanturer")
        {
            moving = true;
            collision.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player_Knight_Advanturer")
        {
            collision.collider.transform.SetParent(null);
            moving = false;
        }
    }
    private void FixedUpdate()
    {
        if (moving)
        {
            transform.position += (velocity * Time.deltaTime);
        }
    }
}
