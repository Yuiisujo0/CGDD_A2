using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LogoTapHandler : MonoBehaviour
{
    public GameObject productGroup;   // Lamp group
    public GameObject videoGroup;     // Video group
    public VideoPlayer videoPlayer;   // Video on the plane
    public PriceTapHandler priceTapHandler; // assign in inspector

    // Any scripts or colliders you want to disable
    public MonoBehaviour[] interactiveScripts;

    void OnMouseDown()
    {
        // Hide price if showing
        if(priceTapHandler != null && priceTapHandler.IsPriceVisible())
            priceTapHandler.HidePrice();

        productGroup.SetActive(false);
        videoGroup.SetActive(true);

        // Disable other interactions
        foreach(var script in interactiveScripts)
        {
            script.enabled = false;
        }

    
        // Read autoplay setting
        bool autoplay = PlayerPrefs.GetInt("VideoAutoplay", 1) == 1;
        if (videoPlayer != null)
        {

            if (autoplay)
                videoPlayer.Play();
            else
                videoPlayer.Pause();
        }
    }
}