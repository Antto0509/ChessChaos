using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string AIdifficulty;
    public string Settings;
    public void StartGame()
    {
        SceneManager.LoadScene(AIdifficulty);
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(Settings);
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }

    public void QuitGame()
    {
        Application.Quit();
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
}
