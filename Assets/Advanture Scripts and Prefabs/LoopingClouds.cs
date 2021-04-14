using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoopingClouds : MonoBehaviour
{
    public Transform pos1, pos2;
    [SerializeField]
    private float speed;
    public Transform startPos;
    Vector2 nextPos;
    void Start()
    {
        nextPos = pos2.position;
    }
    void Update()
    {
        if (transform.position == new Vector3(transform.position.x, transform.position.y, transform.rotation.z))
        {
            transform.position = pos1.position;
        }
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
