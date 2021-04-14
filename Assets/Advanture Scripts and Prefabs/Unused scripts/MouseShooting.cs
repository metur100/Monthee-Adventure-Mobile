using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform start;
    void Update()
    {
        Vector3 gunpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (gunpos.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
        }
        if (Input.GetMouseButtonDown(0)) ;
        {
            shooting();
        }
    }
    void shooting()
    {
        GameObject shoot = Instantiate(bullet, start.transform.position, start.transform.rotation);
        Destroy(shoot, .5f);
    }
}

