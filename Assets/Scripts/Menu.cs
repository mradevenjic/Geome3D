using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadInstructionScene()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
