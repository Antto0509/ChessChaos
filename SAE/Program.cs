using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Chemin vers l'exécutable de Stockfish
        string stockfishPath = "Stockfish/macOS"; // Modifie ce chemin en fonction de ton installation

        // Démarrer le processus Stockfish
        Process stockfish = new Process();
        stockfish.StartInfo.FileName = stockfishPath;
        stockfish.StartInfo.UseShellExecute = false;
        stockfish.StartInfo.RedirectStandardInput = true;
        stockfish.StartInfo.RedirectStandardOutput = true;
        stockfish.StartInfo.CreateNoWindow = true;

        stockfish.Start();

        // Lire la sortie de Stockfish
        stockfish.OutputDataReceived += (sender, e) =>
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                Console.WriteLine("Stockfish: " + e.Data);
            }
        };
        stockfish.BeginOutputReadLine();

        // Envoyer des commandes à Stockfish
        stockfish.StandardInput.WriteLine("uci");
        stockfish.StandardInput.WriteLine("isready");
        stockfish.StandardInput.WriteLine("position startpos");
        stockfish.StandardInput.WriteLine("go depth 10");
        stockfish.StandardInput.WriteLine("quit");

        // Attendre que Stockfish se termine
        stockfish.WaitForExit();
    }
}