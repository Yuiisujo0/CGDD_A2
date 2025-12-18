using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeFurnishingTap : MonoBehaviour
{
    void Update()
    {
        // Only proceed if there is at least one touch
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        // Only detect the start of a tap
        if (touch.phase != TouchPhase.Began)
            return;

        // Raycast from screen touch position
        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Check if THIS object was tapped
            if (hit.transform == transform)
            {
                if (ARManager.Instance != null)
                {
                    ARManager.Instance.LoadInteriorScene();
                }
            }
        }
    }
}