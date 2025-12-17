using UnityEngine.SceneManagement;
using UnityEngine;

public class InteractionInstruction : MonoBehaviour
{
    // Start is called before the first frame update
    public void interactionInstruction()
    {
        SceneManager.LoadSceneAsync("InteractionInstruction");
    }
}
