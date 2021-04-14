using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyWallUpperCave : MonoBehaviour
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
        if (collision.gameObject.tag == "Destroy_Wall_Upper")
        {
            WallHealthUpper eHealth = collision.gameObject.GetComponent<WallHealthUpper>();
            eHealth.ModifyHealth(damageDoneBullet);
        }
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
