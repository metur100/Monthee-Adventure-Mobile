using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBullet : MonoBehaviour
{
    public GameObject explosion;
    public Transform bullet;
    public float colissionRadius = 0.4f;
    public bool collided = false;
    public LayerMask whatToCollideWith;

    void FixedUpdate()
    {
        collided = Physics2D.OverlapCircle(bullet.position, colissionRadius, whatToCollideWith);

        if (collided)
        {
            Instantiate(explosion, bullet.position, transform.rotation = Quaternion.identity);
        }
        if (!GetComponent<Renderer>().isVisible) Destroy(gameObject);
    }
}
