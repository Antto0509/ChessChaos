using System;
using UnityEngine;
using UnityEditor;

public class jeu : MonoBehaviour
{
    public GameObject pionPrefab;
    public Sprite[] whitePawns;
    public Sprite[] blackPawns;

    private void Start()
    {
        // Load the board sprite from the specified path
        Sprite boardSprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Chessboard/Assets/Sprites/board.png");

        // Load the board sprite and set it as the background
        GameObject board = new GameObject("plateau");
        SpriteRenderer boardRenderer = board.AddComponent<SpriteRenderer>();
        boardRenderer.sprite = boardSprite;
        board.transform.position = new Vector3(0, 0, 1); // Ensure the board is behind the pawns

        // Set the scale to 4
        board.transform.localScale = new Vector3(4, 4, 1);

        // Adjust the camera to view the entire board
        Camera.main.transform.position = new Vector3(0, 0, -10);
        Camera.main.orthographic = true;
        Camera.main.orthographicSize = 4.5f;

        // Place white pawns
        for (int i = 0; i < whitePawns.Length; i++)
        {
            GameObject whitePion = Instantiate(pionPrefab, new Vector3(i - 3.5f, -3.5f, -1), Quaternion.identity);
            SpriteRenderer whiteRenderer = whitePion.GetComponent<SpriteRenderer>();
            whiteRenderer.sprite = whitePawns[i];
        }

        // Place black pawns
        for (int i = 0; i < blackPawns.Length; i++)
        {
            GameObject blackPion = Instantiate(pionPrefab, new Vector3(i - 3.5f, 3.5f, -1), Quaternion.identity);
            SpriteRenderer blackRenderer = blackPion.GetComponent<SpriteRenderer>();
            blackRenderer.sprite = blackPawns[i];
        }
    }
}