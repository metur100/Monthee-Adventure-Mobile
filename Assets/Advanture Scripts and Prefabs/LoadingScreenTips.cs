using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LoadingScreenTips : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public List<string> TipList = new List<string>();
    void Start()
    {
        string tipChose = TipList[Random.Range(0, TipList.Count)];
        txt = gameObject.GetComponent<TextMeshProUGUI>();
        txt.text = tipChose;
    }
}