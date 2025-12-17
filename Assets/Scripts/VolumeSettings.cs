using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Load saved volume (default = 1)
        float savedVolume = PlayerPrefs.GetFloat("MasterVolume", 1f);
        volumeSlider.value = savedVolume;

        // Listen for slider changes
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);

        // Apply volume immediately
        AudioListener.volume = savedVolume;
    }

    void OnVolumeChanged(float value)
    {
        // Set global volume
        AudioListener.volume = value;

        // Save volume
        PlayerPrefs.SetFloat("MasterVolume", value);
        PlayerPrefs.Save();
    }
}