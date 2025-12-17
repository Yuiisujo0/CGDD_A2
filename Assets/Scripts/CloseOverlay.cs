using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CloseOverlay : MonoBehaviour
{
    public GameObject productGroup;     // Lamp
    public GameObject overlayGroup;     // VideoGroup / InteriorGroup / StatsGroup
    public VideoPlayer videoPlayer;     // OPTIONAL

    public void Close()
    {
        // Stop video ONLY if this overlay has one
        if (videoPlayer != null)
        {
            videoPlayer.Stop();
        }

        overlayGroup.SetActive(false);
        productGroup.SetActive(true);
    }
}