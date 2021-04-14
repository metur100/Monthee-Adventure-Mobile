using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InvokeBackbackBars : MonoBehaviour
{
    public Button bar1;
    public Button bar2;
    public Button bar3;
    public Button bar4;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            bar1.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            bar2.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            bar3.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            bar4.onClick.Invoke();
        }
    }
}
