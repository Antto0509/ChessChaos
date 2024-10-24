using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AIdifficulty : MonoBehaviour
{
    private Process stockfish;
    public string RetourMainMenu;
    public string Chessboard;
    public int Difficulty;
    public GameObject loadingScreen;
    public Slider slider;
    
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
    
    /* void StartStockfish()
    {
        string stockfishPath = GetStockfishPath();

        if (!string.IsNullOrEmpty(stockfishPath))
        {
            stockfish = new Process();
            stockfish.StartInfo.FileName = stockfishPath;
            stockfish.StartInfo.UseShellExecute = false;
            stockfish.StartInfo.RedirectStandardInput = true;
            stockfish.StartInfo.RedirectStandardOutput = true;
            stockfish.StartInfo.CreateNoWindow = true;
            stockfish.Start();
        }
        else
        {
            Debug.LogError("Impossible de localiser Stockfish pour cet OS.");
        }
    }
    
    string GetStockfishPath()
    {
        string path = string.Empty;

        // Vérifie l'OS sur lequel Unity est exécuté
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            path = Application.dataPath + "/Stockfish/Windows/stockfish-windows-x86-64-avx2.exe";
        }
        else if (Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXEditor)
        {
            path = Application.dataPath + "/Stockfish/macOS/stockfish-macos-m1-apple-silicon";
        }
        else if (Application.platform == RuntimePlatform.LinuxPlayer || Application.platform == RuntimePlatform.LinuxEditor)
        {
            path = Application.dataPath + "/Stockfish/Linux/stockfish-ubuntu-x86-64-sse41-popcnt";
        }

        return path;
    }

    void SetSkillLevel(int level)
    {
        if (stockfish != null && stockfish.HasExited == false)
        {
            stockfish.StandardInput.WriteLine($"setoption name Skill Level value {level}");
            stockfish.StandardInput.Flush();
        }
    } */
    
    public void StartGame(string sceneIndex)
    {
        // StartStockfish();
        // SetSkillLevel(Difficulty);
        StartCoroutine(LoadSync(sceneIndex));
        AudioManager.Instance.PlaySound(AudioType.ClickSound, AudioSourceType.Player);
    }
    
    IEnumerator LoadSync(string sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        
        loadingScreen.SetActive(true);
        
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
    }

    /* void OnApplicationQuit()
    {
        if (stockfish != null && stockfish.HasExited == false)
        {
            stockfish.StandardInput.WriteLine("quit");
            stockfish.StandardInput.Flush();
            stockfish.Close();
        }
    } */
}
