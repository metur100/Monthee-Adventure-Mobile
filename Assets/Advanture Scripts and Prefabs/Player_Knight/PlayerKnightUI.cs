using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerKnightUI : MonoBehaviour
{
    public Button questButton;
    public Button backpackButton;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            questButton.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            backpackButton.onClick.Invoke();
        }
    }
}
