using System;
using UnityEngine;

public class ChessGameManager : MonoBehaviour
{
    private char[,] board;

    private void Start()
    {
        // Initialiser le plateau de jeu
        board = new char[8, 8];
        InitializeBoard();
        Debug.Log("Jeu d'échecs initialisé");
    }

    private void InitializeBoard()
    {
        // Initialiser les pions blancs
        for (int i = 0; i < 8; i++)
        {
            board[1, i] = 'P'; // Pion blanc
        }

        // Initialiser les pions noirs
        for (int i = 0; i < 8; i++)
        {
            board[6, i] = 'p'; // Pion noir
        }

        // Initialiser les autres pièces (optionnel)
        // ...
    }

    // Méthode pour vérifier si un coup est légal pour un pion
    public bool IsLegalPawnMove(int fromX, int fromY, int toX, int toY)
    {
        char piece = board[fromX, fromY];

        if (piece == 'P') // Pion blanc
        {
            // Vérifier les mouvements vers l'avant
            if (fromX == 1 && toX == fromX + 2 && fromY == toY && board[toX, toY] == '\0')
            {
                return true; // Premier mouvement de deux cases
            }
            if (toX == fromX + 1 && fromY == toY && board[toX, toY] == '\0')
            {
                return true; // Mouvement d'une case
            }
            // Vérifier les captures
            if (toX == fromX + 1 && Math.Abs(toY - fromY) == 1 && board[toX, toY] != '\0' && char.IsLower(board[toX, toY]))
            {
                return true; // Capture diagonale
            }
        }
        else if (piece == 'p') // Pion noir
        {
            // Vérifier les mouvements vers l'avant
            if (fromX == 6 && toX == fromX - 2 && fromY == toY && board[toX, toY] == '\0')
            {
                return true; // Premier mouvement de deux cases
            }
            if (toX == fromX - 1 && fromY == toY && board[toX, toY] == '\0')
            {
                return true; // Mouvement d'une case
            }
            // Vérifier les captures
            if (toX == fromX - 1 && Math.Abs(toY - fromY) == 1 && board[toX, toY] != '\0' && char.IsUpper(board[toX, toY]))
            {
                return true; // Capture diagonale
            }
        }

        return false; // Mouvement illégal
    }

    // Méthode pour effectuer un coup
    public bool MovePiece(int fromX, int fromY, int toX, int toY)
    {
        if (IsLegalPawnMove(fromX, fromY, toX, toY))
        {
            board[toX, toY] = board[fromX, fromY];
            board[fromX, fromY] = '\0';
            Debug.Log($"Coup validé de ({fromX}, {fromY}) à ({toX}, {toY})");
            return true;
        }
        else
        {
            Debug.Log($"Coup invalide de ({fromX}, {fromY}) à ({toX}, {toY})");
            return false;
        }
    }

    // Méthode pour afficher le plateau (optionnel pour le débogage)
    public void DisplayBoard()
    {
        for (int x = 0; x < 8; x++)
        {
            string row = "";
            for (int y = 0; y < 8; y++)
            {
                row += board[x, y] == '\0' ? "." : board[x, y].ToString();
                row += " ";
            }
            Debug.Log(row);
        }
    }
}