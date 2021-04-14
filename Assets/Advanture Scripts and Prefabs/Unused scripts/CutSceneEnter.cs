using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutSceneCam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        cutSceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut());
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(10);
        thePlayer.SetActive(true);
        cutSceneCam.SetActive(false);
    }
}
