//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class FillStatusHealthBar : MonoBehaviour
//{
//    public HealthNinja healthNjinja;
//    public Image fillImage;
//    private Slider slider;
//    // Start is called before the first frame update
//    void Start()
//    {
//        slider = GetComponent<Slider>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (slider.value <= slider.minValue)
//        {
//            fillImage.enabled = false;
//        }
//        if (slider.value > slider.minValue && !fillImage.enabled)
//        {
//            fillImage.enabled = true;
//        }
//        float fillValue = healthNjinja.currentHealth / healthNjinja.maxHealth;
//        if (fillValue <= slider.maxValue / 3)
//        {
//            fillImage.color = Color.white;
//        }
//        else if (fillValue > slider.maxValue / 3)
//        {
//            fillImage.color = Color.red;
//        }
//        slider.value = fillValue;
//    }
//}
