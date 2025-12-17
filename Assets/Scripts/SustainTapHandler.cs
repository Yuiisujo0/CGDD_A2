using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SustainTapHandler : MonoBehaviour
{
    public GameObject sustainGroup; // Assign your SustainGroup here
    public GameObject otherGroup;   // Optional: objects to hide when showing stats
    public PriceTapHandler priceTapHandler; // Assign your PriceTapHandler here

    void OnMouseDown()
    {
        // Hide the price if it's showing
        if(priceTapHandler != null)
            priceTapHandler.HidePriceOnOtherGroup();

        // Hide other objects if needed
        if(otherGroup != null)
            otherGroup.SetActive(false);

        // Show sustainability stats
        if(sustainGroup != null)
            sustainGroup.SetActive(true);
    }

    // Call this from the Close button
    public void CloseSustain()
    {
        if(sustainGroup != null)
            sustainGroup.SetActive(false);

        // Optionally show the other objects again
        if(otherGroup != null)
            otherGroup.SetActive(true);
    }
}
