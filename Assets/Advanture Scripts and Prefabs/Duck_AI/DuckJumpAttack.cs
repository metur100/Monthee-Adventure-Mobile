using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckJumpAttack : MonoBehaviour
{
    public float speed = 4f;
    public float jetPackSpeed = 0.3f;
    public float jumpSpeed = 8f;
    public float gravity = 10;
    private Transform _Player;
    private CharacterController character;
    private Transform tr;
    private float vSpeed = 0f;
    private bool jump = false;

    void Start()
    {
        _Player = GameObject.FindGameObjectWithTag("Player_Knight_Advanturer").transform;
        character = GetComponent<CharacterController>();
        tr = transform;
    }
    void Update()
    {    // find the vector enemy -> player
        Vector3 chaseDir = _Player.position - tr.position;
        chaseDir.y = 0; // let only the horizontal direction
        float distance = chaseDir.magnitude;  // get the distance
        if (distance <= 2)
            Debug.Log("Attacking Player");
        else
        {    // find the player direction
            Quaternion rot = Quaternion.LookRotation(chaseDir);
            // rotate to his direction
            tr.rotation = Quaternion.Slerp(tr.rotation, rot, Time.deltaTime * 4);
            if (character.isGrounded)
            { // if is grounded...
                vSpeed = 0;  // vertical speed  is zero
                if (jump)
                {    // if should jump...
                    vSpeed = jumpSpeed; // aplly jump speed
                    jump = false; // only jump once!
                }
            }
            else // but if lost ground, check if it's an abyss
            if (!Physics.Raycast(tr.position, -tr.up, 20f))
            { // if no ground below
                vSpeed = jetPackSpeed;  // use jetpack
            }
            vSpeed -= gravity * Time.deltaTime; // apply gravity
                                                // calculate horizontal velocity vector
            chaseDir = chaseDir.normalized * speed;
            chaseDir.y += vSpeed; // include vertical speed
                                  // and move the enemy
            character.Move(chaseDir * Time.deltaTime);
        }
    }

    // if collided with some wall or block, jump
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // only check lateral collisions
        if (Mathf.Abs(hit.normal.y) < 0.5)
        {
            jump = true; // jump if collided laterally
        }
    }
}
