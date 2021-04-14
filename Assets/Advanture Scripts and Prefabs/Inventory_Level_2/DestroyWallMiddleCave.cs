using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyWallMiddleCave : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneBullet = -50;
    private readonly float speedOfBullet = 150f;
    void Start()
    {
        StartCoroutine(DestroyGameobject());
        rb.velocity = transform.right * speedOfBullet;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destroy_Wall_Middle"))
        {
            WallHealthMiddle eHealth = collision.gameObject.GetComponent<WallHealthMiddle>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
