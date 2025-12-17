using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARManager : MonoBehaviour
{
    public static ARManager Instance;

    public string arSceneName = "SampleScene";
    public string interiorSceneName = "InteriorScene1";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadARScene()
    {
        SceneManager.LoadScene(arSceneName, LoadSceneMode.Single);
    }

    public void LoadInteriorScene()
    {
        SceneManager.LoadScene(interiorSceneName, LoadSceneMode.Single);
    }
}