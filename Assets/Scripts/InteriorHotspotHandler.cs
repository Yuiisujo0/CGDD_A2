using System.Collections;
using System.Collections.Generic;
using Lean.Touch;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteriorHotspotHandler : MonoBehaviour
{
    public void OnTap()
    {
        SceneManager.LoadScene("InteriorScene");
    }
}

