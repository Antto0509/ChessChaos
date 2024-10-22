using UnityEngine;
using UnityEngine.SceneManagement;

public class AIdifficulty : MonoBehaviour
{
    public string RetourMainMenu;
    public string Chessboard;
    
    public void Retour()
    {
        SceneManager.LoadScene(RetourMainMenu);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(Chessboard);
    }
}
