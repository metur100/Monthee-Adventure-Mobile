using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingOnMouse : MonoBehaviour
{
    public GameObject projectile;
    public float laucnForce;
    public Transform shotPoint;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 bowPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - bowPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject newProjectile = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
        newProjectile.GetComponent<Rigidbody2D>().velocity = transform.right * laucnForce;
    }
}
