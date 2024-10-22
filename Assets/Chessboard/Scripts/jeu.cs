using System;
using UnityEngine;
using UnityEditor;

public class jeu : MonoBehaviour
{
    public string whitePawnPath = "Assets/Chessboard/Assets/Sprites/white_pawn.png";
    public string blackPawnPath = "Assets/Chessboard/Assets/Sprites/black_pawn.png";
    public string boardPath = "Assets/Chessboard/Assets/Sprites/board.png";

    private const float tileSize = 1.0f;
    private const float boardOffsetX = 3.5f;
    private const float boardOffsetY = 3.5f;

    private void Start()
    {
        Sprite boardSprite = AssetDatabase.LoadAssetAtPath<Sprite>(boardPath);

        GameObject board = new GameObject("plateau");
        SpriteRenderer boardRenderer = board.AddComponent<SpriteRenderer>();
        boardRenderer.sprite = boardSprite;
        board.transform.position = new Vector3(0, 0, 1);

        board.transform.localScale = new Vector3(4, 4, 1);

        Camera.main.transform.position = new Vector3(0, 0, -10);
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 4.5f;

        Sprite whitePawnSprite = AssetDatabase.LoadAssetAtPath<Sprite>(whitePawnPath);
        Sprite blackPawnSprite = AssetDatabase.LoadAssetAtPath<Sprite>(blackPawnPath);

        for (int i = 0; i < 8; i++)
        {
            GameObject whitePion = new GameObject("WhitePawn" + i);
            SpriteRenderer whiteRenderer = whitePion.AddComponent<SpriteRenderer>();
            whiteRenderer.sprite = whitePawnSprite;

            whitePion.transform.position = new Vector3(i - boardOffsetX + tileSize / 2, -1 + tileSize / 2, -0.1f);
            whitePion.transform.localScale = new Vector3(4, 4, 1);
        }

        for (int i = 0; i < 8; i++)
        {
            GameObject blackPion = new GameObject("BlackPawn" + i);
            SpriteRenderer blackRenderer = blackPion.AddComponent<SpriteRenderer>();
            blackRenderer.sprite = blackPawnSprite;

            blackPion.transform.position = new Vector3(i - boardOffsetX + tileSize / 2, 1 + tileSize / 2, -0.1f);
            blackPion.transform.localScale = new Vector3(4, 4, 1);
        }
    }
}