using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoAutoplayToggle : MonoBehaviour
{
    public Toggle toggle;

    void Start()
    {
        if (AppSettings.Instance != null)
            toggle.isOn = AppSettings.Instance.videoAutoplay;

        toggle.onValueChanged.AddListener(OnToggleChanged);
    }

    void OnToggleChanged(bool value)
    {
        if (AppSettings.Instance != null)
            AppSettings.Instance.videoAutoplay = value;
    }
}

