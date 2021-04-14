using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    public static bool isCutSceneOn;
    public Animator camAnim;
    public GameObject createPlatform;
    public GameObject effectCreatingPlatform;
    public Transform posCreatePlatform;
    public PlayerMovementAdvanturerKnight moveSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_Knight_Advanturer"))
        {
            moveSpeed.normalMovementSpeed = 0;
            Invoke(nameof(CreatePlatform), 2f);
            isCutSceneOn = true;
            camAnim.SetBool("IsCutscene", true);
            Invoke(nameof(StopCutscene), 5f);
        }
    }
    void StopCutscene()
    {
        isCutSceneOn = false;
        camAnim.SetBool("IsCutscene", false);
        moveSpeed.normalMovementSpeed = 400; 
    }
    void CreatePlatform()
    {
        FindObjectOfType<AudioManager>().Play("MonD_CreatePlatform");
        Instantiate(effectCreatingPlatform, posCreatePlatform.transform.position, Quaternion.identity);
        createPlatform.SetActive(true);  
    }
}
