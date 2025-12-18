using System.Collections;
using System.Collections.Generic;
using Lean.Touch;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteriorHotspotHandler : MonoBehaviour
{
    [Header("Scene to Load")]
    public string sceneName = "InteriorScene1"; // Assign the scene in Inspector

    void Update()
    {
        if (Input.touchCount == 0) 
            return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) 
            return;

        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.transform == transform)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
