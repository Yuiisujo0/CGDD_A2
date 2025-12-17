using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("Splash Screen Settings")]
    public bool isSplashScreen = false;
    public float delayTime = 3f;
    public string splashNextScene = "MainMenu";

    [Header("Scene Names")]
    public string mainMenuScene = "MainMenu";
    public string settingsScene = "Settings";
    public string arScene = "ARActivationScreen";
    public string cameraScene = "SampleScene";
    public string aboutScene = "About";
    public string interactionInstructionScene = "InteractionInstruction";

    void Start()
    {
        // SplashScreen.cs behavior
        if (isSplashScreen)
        {
            StartCoroutine(LoadMainMenuAfterDelay());
        }
    }

    IEnumerator LoadMainMenuAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("MainMenu");
    }

    // ===== Button Methods (REPLACEMENT FOR ALL YOUR SCRIPTS) =====

    // backToMainMenu.cs
    public void BackToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    // Settings.cs
    public void OpenSettings()
    {
        SceneManager.LoadSceneAsync("Settings");
    }

    // openCam.cs
    public void OpenCamera()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    // About.cs
    public void OpenAbout()
    {
        SceneManager.LoadSceneAsync("About");
    }

    // InteractionInstruction.cs
    public void OpenInteractionInstruction()
    {
        SceneManager.LoadSceneAsync("InteractionInstruction");
    }

    // ArActivation.cs
    public void OpenARActivation()
    {
        SceneManager.LoadSceneAsync("ARActivationScreen");
    }

    // backToARActivation.cs
    public void BackToARActivation()
    {
        SceneManager.LoadSceneAsync("ARActivationScreen");
    }

    // goToHint1.cs
    public void GoToHint1()
    {
        SceneManager.LoadSceneAsync("Hint01");
    }

    // goToHint2.cs
    public void GoToHint2()
    {
        SceneManager.LoadSceneAsync("Hint02");
    }

    // goToHint3.cs
    public void GoToHint3()
    {
        SceneManager.LoadSceneAsync("Hint03");
    }

    // goToHint4.cs
    public void GoToHint4()
    {
        SceneManager.LoadSceneAsync("Hint04");
    }

    // goToHint5.cs
    public void GoToHint5()
    {
        SceneManager.LoadSceneAsync("Hint05");
    }

    // goToPoster.cs
    public void GoToPoster()
    {
        SceneManager.LoadSceneAsync("ViewPoster");
    }
}