using UnityEngine.SceneManagement;
using UnityEngine;

public class Settings : MonoBehaviour
{
    // Start is called before the first frame update
    public void settings()
    {
        SceneManager.LoadSceneAsync("Settings");
    }
}
