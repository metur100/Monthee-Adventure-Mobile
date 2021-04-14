using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockCanvasCastingBar : MonoBehaviour
{
    private float posXMinus = -132f;
    private float posXPlus = -132f;
    private float posYMinus = 71f;
    private float posYPlus = 71f;
    Transform t;
    public float fixedRotation = 5;

    void Start()
    {
        t = transform;
    }
    //t.eulerAngles = new Vector3(0f, 180f, 0f);

    void Update()
    {
        t.eulerAngles = new Vector3(t.eulerAngles.x, fixedRotation, t.eulerAngles.z);

        if (transform.position.x < posXMinus)
        {
            transform.position = new Vector3(posXMinus, transform.position.y, transform.position.z);
        }

        if (transform.position.x > posXPlus)
        {
            transform.position = new Vector3(posXPlus, transform.position.y, transform.position.z);
        }

        if (transform.position.y < posYMinus)
        {
            transform.position = new Vector3(transform.position.x, posYMinus);
        }

        if (transform.position.y > posYPlus)
        {
            transform.position = new Vector3(transform.position.x, posYPlus);
        }
    }
}