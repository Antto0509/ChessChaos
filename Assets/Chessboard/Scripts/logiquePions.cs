/*using System;
using UnityEngine;
using ChessSharp; // Assure-toi que ChessSharp est bien importé

public class ChessGameManager : MonoBehaviour
{
    private Game game;

    private void Start()
    {
        // Initialisation du jeu d'échecs avec ChessSharp
        game = new Game();
        Debug.Log("Jeu d'échecs initialisé");
    }

    // Méthode pour effectuer un coup
    public bool MovePiece(string from, string to)
    {
        bool moveResult = game.Move(from, to);
        if (moveResult)
        {
            Debug.Log($"Coup validé de {from} à {to}");
        }
        else
        {
            Debug.Log($"Coup invalide de {from} à {to}");
        }
        return moveResult;
    }

    // Méthode pour afficher le plateau (optionnel pour debug)
    public void DisplayBoard()
    {
        string boardState = game.Board.ToString();
        Debug.Log(boardState);
    }
}*/