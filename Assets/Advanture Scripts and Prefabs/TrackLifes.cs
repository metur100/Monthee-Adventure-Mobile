using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrackLifes : MonoBehaviour
{
    public static int scoreValue = 5;
    TextMeshProUGUI score;
    void Start()
    {
        scoreValue = 5;
        score = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        score.text = "" + scoreValue;
    }
}
