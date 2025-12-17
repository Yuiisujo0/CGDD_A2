using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoSettings : MonoBehaviour
{
    public Toggle autoplayToggle;

    void Start()
    {
        // Load saved setting (default ON)
        autoplayToggle.isOn = PlayerPrefs.GetInt("VideoAutoplay", 1) == 1;

        // Listen for changes
        autoplayToggle.onValueChanged.AddListener(OnToggleChanged);
    }

    void OnToggleChanged(bool value)
    {
        PlayerPrefs.SetInt("VideoAutoplay", value ? 1 : 0);
        PlayerPrefs.Save();
    }
}
