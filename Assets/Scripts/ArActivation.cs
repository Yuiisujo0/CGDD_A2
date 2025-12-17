using UnityEngine;
using UnityEngine.SceneManagement;

public class ArActivation : MonoBehaviour
{
    // Start is called before the first frame update
    public void ARActivation()
    {
        SceneManager.LoadSceneAsync("ARActivationScreen");
    }
}
