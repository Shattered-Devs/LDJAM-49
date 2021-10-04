using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene("Scenes/Prototype", LoadSceneMode.Single);
    }

    public void OnGameoverButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scenes/Prototype", LoadSceneMode.Single);
    }
}
