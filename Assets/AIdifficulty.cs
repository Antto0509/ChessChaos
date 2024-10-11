using UnityEngine;
using UnityEngine.SceneManagement;

public class AIdifficulty : MonoBehaviour
{
    public string RetourMainMenu; 
    
    public void Retour()
    {
        SceneManager.LoadScene(RetourMainMenu);
    }
}
