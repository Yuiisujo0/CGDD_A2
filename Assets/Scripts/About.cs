using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{
    // Start is called before the first frame update
    public void about()
    {
        SceneManager.LoadSceneAsync("About");
    }
}
