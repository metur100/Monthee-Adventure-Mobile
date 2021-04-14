using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackQuestProgress : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        score.text = "Enemies killed " + scoreValue + " of 15";
    }
}
