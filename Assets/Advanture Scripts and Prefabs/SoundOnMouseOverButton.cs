using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnMouseOverButton : MonoBehaviour
{
    public GameObject audioMouseOver;
    public GameObject audioOnClick;
    public void DropMouseOverAudio()
    {
        Instantiate(audioMouseOver, transform.position, transform.rotation);
    }
    public void DropOnClickAudio()
    {
        Instantiate(audioOnClick, transform.position, transform.rotation);
    }
}
