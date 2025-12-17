using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LogoTapHandler : MonoBehaviour
{
    public GameObject productGroup;   // Lamp group
    public GameObject videoGroup;     // Video group
    public GameObject videoBlocker;   // Quad blocker
    public VideoPlayer videoPlayer;   // Video on the plane
    public PriceTapHandler priceTapHandler;

    // Any scripts or colliders you want to disable
    public MonoBehaviour[] interactiveScripts;

    void OnMouseDown()
    {
        // Hide price if showing
        if (priceTapHandler != null && priceTapHandler.IsPriceVisible())
            priceTapHandler.HidePrice();

        // Show video panel
        productGroup.SetActive(false);
        videoGroup.SetActive(true);

        // Enable blocker
        if (videoBlocker != null)
            videoBlocker.SetActive(true);

        // Disable other interactive scripts
        foreach (var script in interactiveScripts)
            script.enabled = false;

        // Video autoplay
        bool autoplay = PlayerPrefs.GetInt("VideoAutoplay", 1) == 1;
        if (videoPlayer != null)
        {
            if (AppSettings.Instance != null)
                videoPlayer.SetDirectAudioVolume(0, AppSettings.Instance.videoVolume);

            if (autoplay)
                videoPlayer.Play();
            else
                videoPlayer.Pause();
        }
    }

    // Call this from Back button
    public void CloseVideo()
    {
        videoGroup.SetActive(false);

        if (videoBlocker != null)
            videoBlocker.SetActive(false);

        foreach (var script in interactiveScripts)
            script.enabled = true;

        productGroup.SetActive(true);

        if (videoPlayer != null)
            videoPlayer.Pause();
    }
}
