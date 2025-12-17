using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SustainTapHandler : MonoBehaviour
{
    [Header("Panels")]
    public GameObject sustainGroup;    // Sustainability panel
    public GameObject otherGroup;      // Other objects to hide
    public GameObject blocker;         // Full-screen transparent blocker

    [Header("Price")]
    public PriceTapHandler priceTapHandler; // Price script to hide

    [Header("Interaction Scripts")]
    public MonoBehaviour[] interactiveScripts; // Scripts to disable while sustain is open

    void OnMouseDown()
    {
        // Always hide price when sustain is tapped
        if(priceTapHandler != null && priceTapHandler.IsPriceVisible())
            priceTapHandler.HidePrice();

        if(otherGroup != null)
            otherGroup.SetActive(false);

        if(sustainGroup != null)
            sustainGroup.SetActive(true);

        if(blocker != null)
            blocker.SetActive(true);

        // Disable interactions behind
        foreach(var script in interactiveScripts)
            script.enabled = false;
    }

    public void CloseSustain()
    {
        if(sustainGroup != null)
            sustainGroup.SetActive(false);

        if(blocker != null)
            blocker.SetActive(false);

        // Re-enable other interactions
        foreach(var script in interactiveScripts)
            script.enabled = true;

        if(otherGroup != null)
            otherGroup.SetActive(true);
    }
}