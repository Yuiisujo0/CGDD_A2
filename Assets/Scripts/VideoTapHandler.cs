using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTapHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
        // Handle touch input
        if (Input.touchCount > 0 && videoPlayer != null)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == transform)
                    {
                        // Toggle video play/pause
                        if (videoPlayer.isPlaying)
                            videoPlayer.Pause();
                        else
                            videoPlayer.Play();
                    }
                }
            }
        }

        // Update volume every frame
        if (videoPlayer != null && AppSettings.Instance != null)
        {
            videoPlayer.SetDirectAudioVolume(0, AppSettings.Instance.videoVolume);
        }
    }
}
