using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string AIdifficulty;
    public void StartGame()
    {
        SceneManager.LoadScene(AIdifficulty);
    }

    public void SettingsButton()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
