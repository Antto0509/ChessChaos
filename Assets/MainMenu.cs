using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string AIdifficulty;
    public string Settings;
    public void StartGame()
    {
        SceneManager.LoadScene(AIdifficulty);
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(Settings);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
