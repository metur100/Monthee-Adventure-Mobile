using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrackQuestProgressRunes : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        score.text = "Runes gethered " + scoreValue + " of 3";
    }
}
