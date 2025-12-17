using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeFurnishingTap : MonoBehaviour
{
    void OnMouseDown()
    {
        if (ARManager.Instance != null)
        {
            ARManager.Instance.LoadInteriorScene();
        }
    }
}