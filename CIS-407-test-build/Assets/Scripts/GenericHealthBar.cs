using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenericHealthBar : MonoBehaviour
{
    public Image slider;
    public Text health_text;

    float maxValue;
    float value;

    public void SetMaxValue(float v)
    {
        maxValue = v;
    }

    public void SetValue(float v)
    {
        value = v;
    }

    private void Start()
    {
        slider.fillAmount = 1;
    }

    private void Update()
    {
        slider.fillAmount = value / maxValue;
        health_text.text = value.ToString() + " / " + maxValue.ToString();
        // Debug.Log(value + " / " + maxValue);
    }
}
