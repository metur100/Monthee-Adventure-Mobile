using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAutoAttack : MonoBehaviour
{
    public float Range;
    public Transform Target;
    bool Detected = false;
    Vector2 Direction;
    //public GameObject Gun;
    public GameObject bullet;
    public float FireRate;
    float nextTimeToFire = 0;
    public Transform Shootpoint;
    public float Force;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            Vector2 targetPos = Target.position;
            Direction = targetPos - (Vector2)transform.position;
            RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Range);
            if (rayInfo)
            {
                if (rayInfo.collider.gameObject.CompareTag("Player_Knight_Advanturer"))
                {
                    if (Detected == false)
                    {
                        Detected = true;
                    }
                }
                else
                {
                    if (Detected == true)
                    {
                        Detected = false;
                    }
                }
            }
            if (Detected)
            {
                //Gun.transform.up = Direction;
                if (Time.time > nextTimeToFire)
                {
                    nextTimeToFire = Time.time + 2 / FireRate;
                    Shoot();
                    animator.SetTrigger("IsAttacking");
                   // FindObjectOfType<AudioManager>().Play("Plant_Shoot");
                }
            }
        }
    }
    void Shoot()
    {
        GameObject BulletIns = Instantiate(bullet, Shootpoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * Force);
    }
}
