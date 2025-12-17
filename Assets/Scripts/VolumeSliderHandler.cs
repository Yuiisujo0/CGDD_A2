using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderHandler : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        if (AppSettings.Instance != null)
        {
            volumeSlider.value = AppSettings.Instance.videoVolume;
        }

        volumeSlider.onValueChanged.AddListener(OnSliderChanged);
    }

    void OnSliderChanged(float value)
    {
        if (AppSettings.Instance != null)
            AppSettings.Instance.videoVolume = value;
    }
}
