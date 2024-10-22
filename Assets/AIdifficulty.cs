using UnityEngine;
using UnityEngine.SceneManagement;

public class AIdifficulty : MonoBehaviour
{
    public string RetourMainMenu;
    public string Chessboard;
    public int Difficulty;
    
    public void Retour()
    {
        SceneManager.LoadScene(RetourMainMenu);
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }

    public void Facile()
    {
        Difficulty = 5;
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
    
    public void Moyen()
    {
        Difficulty = 10;
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
    
    public void Difficile()
    {
        Difficulty = 15;
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
    
    public void Expert()
    {
        Difficulty = 20;
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
    
    public void StartGame()
    {
        PlayerPrefs.SetInt("Difficulty", Difficulty);
        SceneManager.LoadScene(Chessboard);
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
}
