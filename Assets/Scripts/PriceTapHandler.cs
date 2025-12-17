using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PriceTapHandler : MonoBehaviour
{
    public TextMeshPro priceText;          // Assign the TextMeshPro child
    public string[] currencies = { "$", "€", "£" }; 
    public float[] amounts = { 49.99f, 45.99f, 39.99f }; 

    private int currentIndex = 0;
    private bool isVisible = false;

    void Start()
    {
        if(priceText != null)
            priceText.gameObject.SetActive(false); // Hide initially
    }

    void OnMouseDown()
    {
        if(priceText == null) return;

        if(!isVisible)
        {
            ShowPrice();
        }
        else
        {
            // Cycle to next currency
            currentIndex++;
            if(currentIndex >= currencies.Length)
                currentIndex = 0;

            UpdatePriceText();
        }
    }

    void ShowPrice()
    {
        priceText.gameObject.SetActive(true);
        isVisible = true;
        UpdatePriceText();
    }

    public void HidePrice()
    {
        priceText.gameObject.SetActive(false);
        isVisible = false;
    }

    void UpdatePriceText()
    {
        if(priceText != null)
            priceText.text = currencies[currentIndex] + amounts[currentIndex].ToString("F2");
    }

    // Call this method from your LogoTapHandler, SustainTapHandler, etc.
    public void HidePriceOnOtherGroup()
    {
        if(isVisible)
            HidePrice();
    }

    public bool IsPriceVisible()
    {
        return isVisible;
    }
}
