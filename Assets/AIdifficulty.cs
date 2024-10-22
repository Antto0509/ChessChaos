using UnityEngine;
using UnityEngine.SceneManagement;

public class AIdifficulty : MonoBehaviour
{
    public string RetourMainMenu;
    public string Chessboard;
    
    public void Retour()
    {
        SceneManager.LoadScene(RetourMainMenu);
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(Chessboard);
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
}
