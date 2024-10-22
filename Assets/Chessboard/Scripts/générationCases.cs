using UnityEngine;

public class Tile : MonoBehaviour
{
    private void OnMouseDown()
    {
        string chessCoordinates = GetChessCoordinates();
        Debug.Log($"Tile clicked at position {chessCoordinates}");
        // Add logic to handle the click event, e.g., move the piece to this tile if the move is legal
    }

    private string GetChessCoordinates()
    {
        int x = Mathf.RoundToInt(transform.position.x + 3.5f);
        int y = Mathf.RoundToInt(transform.position.y + 3.5f);
        char file = (char)('A' + x);
        int rank = y + 1;
        return $"{file}{rank}";
    }
}