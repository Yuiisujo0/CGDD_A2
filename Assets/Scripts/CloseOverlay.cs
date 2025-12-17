using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CloseOverlay : MonoBehaviour
{
    public GameObject productGroup;     // Lamp
    public GameObject overlayGroup;     // VideoGroup / InteriorGroup / StatsGroup
    public VideoPlayer videoPlayer;     // OPTIONAL

    // Any scripts or colliders you want to disable
    public MonoBehaviour[] interactiveScripts;

    public void Close()
    {
        // Re-enable interactions
        foreach(var script in interactiveScripts)
        {
            script.enabled = true;
        }
        
        // Stop video ONLY if this overlay has one
        if (videoPlayer != null)
        {
            videoPlayer.Stop();
        }

        overlayGroup.SetActive(false);
        productGroup.SetActive(true);
    }
}