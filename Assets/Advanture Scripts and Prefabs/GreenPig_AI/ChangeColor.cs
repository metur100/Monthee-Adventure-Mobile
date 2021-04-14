using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer spriteColor;
    public GreenPigHealth current;
    void Start()
    {
        spriteColor = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (current.currentHealth <= 250)
        {
            spriteColor.color = new Color(255, 0, 0, 255);
        }
    }
}
