using System.Collections;
using TMPro;
using UnityEngine;

public class TrackPlayerLevels : MonoBehaviour
{
    public static int scoreValue;
    TextMeshProUGUI score;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        scoreValue = 1;
    }

    void Update()
    {
        score.text = "" + scoreValue;
    }
}
