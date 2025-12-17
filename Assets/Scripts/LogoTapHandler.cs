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

    void OnMouseDown()
    {
        // Hide price if it's showing
        if(priceTapHandler != null)
            priceTapHandler.HidePriceOnOtherGroup();

        productGroup.SetActive(false);
        videoGroup.SetActive(true);
        videoPlayer.Play();
    }
}