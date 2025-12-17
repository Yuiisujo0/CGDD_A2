using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTapHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void OnMouseDown()
    {
        if(videoPlayer == null) return;

        if(videoPlayer.isPlaying)
            videoPlayer.Pause();
        else
            videoPlayer.Play();
    }

    void Update()
    {
        if (videoPlayer != null && AppSettings.Instance != null)
        {
            videoPlayer.SetDirectAudioVolume(0, AppSettings.Instance.videoVolume);
        }
    }
}
