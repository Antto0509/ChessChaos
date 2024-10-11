using UnityEngine;

namespace Chessboard
{
    public class Chessboard : MonoBehaviour
    {
        void Start()
        {
            float squareSize = 1.0f; // Size of each square

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    // Create a new square
                    GameObject square = GameObject.CreatePrimitive(PrimitiveType.Quad);
                    square.name = $"Square_{x}_{y}";
                    square.transform.position = new Vector3(x * squareSize, y * squareSize, 0);

                    // Assign the color based on the position
                    Renderer renderer = square.GetComponent<Renderer>();
                    if ((x + y) % 2 == 0)
                    {
                        renderer.material.color = Color.black;
                    }
                    else
                    {
                        renderer.material.color = Color.white;
                    }
                }
            }

            // Position the camera to view the chessboard
            Camera.main.transform.position = new Vector3(4 * squareSize, 4 * squareSize, -10);
            Camera.main.orthographic = true;
            Camera.main.orthographicSize = 4.5f;
        }
    }
}