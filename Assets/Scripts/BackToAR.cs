using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToAR : MonoBehaviour
{
    public void GoBack()
    {
        Debug.Log("Back button pressed");

        if (ARManager.Instance != null)
        {
            ARManager.Instance.LoadARScene();
        }
        else
        {
            Debug.LogError("ARManager instance NOT FOUND");
        }
    }
}

