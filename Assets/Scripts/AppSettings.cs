using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSettings : MonoBehaviour
{
    public static AppSettings Instance;

    [Header("Video Settings")]
    public bool videoAutoplay = true;

    [Header("Audio Settings")]
    [Range(0f, 1f)]
    public float videoVolume = 1f; // default full volume

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
