using UnityEngine;
using UnityEngine.UI;

public class OffScreenIndicator : MonoBehaviour
{
    [SerializeField] private Image _uiArrow;
    [SerializeField] private Image _uiIndicator;
    [SerializeField] private Transform _trackingObject;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateOffscrenIndicator(_trackingObject.position);
    }


    private void UpdateOffscrenIndicator(Vector3 position)
    {
        // Based on code from https://www.youtube.com/watch?v=gAQpR1GN0Os
        // youtube user digijin

        Vector3 screenpos = Camera.main.WorldToScreenPoint(position);

        if (screenpos.z > 0 && screenpos.x > 0 && screenpos.x < Screen.width && screenpos.y > 0 && screenpos.y < Screen.height)
        {
            // THE OBJECT IS INSIDE VIEW
            _uiIndicator.transform.position = screenpos;
            _uiIndicator.transform.rotation = Quaternion.Euler(0, 0, 0);
            _uiIndicator.enabled = true;
            _uiArrow.enabled = false;
        }
        else
        {
            // THE OBJECT IS OUTSIDE VIEW
            _uiIndicator.enabled = false;
            _uiArrow.enabled = true;

            Vector3 screenCenter = new Vector3(Screen.width, Screen.height, 0) / 2;

            screenpos -= screenCenter;

            if (screenpos.z < 0)
            {
                screenpos *= -1;
            }

            float angle = Mathf.Atan2(screenpos.y, screenpos.x);
            angle -= 90 * Mathf.Deg2Rad;

            float cos = Mathf.Cos(angle);
            float sin = Mathf.Sin(angle);

            screenpos = screenCenter + new Vector3(sin * 150, cos * 150, 0);

            float m = cos / sin;
            Vector3 screenBounds = screenCenter * 1f;

            screenpos = cos > 0 ? new Vector3(-screenBounds.y / m, screenCenter.y, 0) : new Vector3(screenBounds.y / m, -screenCenter.y, 0);

            if (screenpos.x > screenBounds.x)
            {
                screenpos = new Vector3(screenBounds.x, -screenBounds.x * m, 0);
            }
            else if (screenpos.x < -screenBounds.x)
            {
                screenpos = new Vector3(-screenBounds.x, screenBounds.x * m, 0);
            }

            screenpos += screenCenter;

            _uiArrow.transform.position = screenpos;
            _uiArrow.transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg);
        }
    }
}