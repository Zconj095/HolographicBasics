using UnityEngine;

public class HolographicPixelDensitySimulator : MonoBehaviour
{
    public GameObject pixelPrefab; // The prefab representing a single pixel
    public int pixelsPerRow = 10; // Starting pixel density (pixels per row and column)
    public float displaySize = 1.0f; // Size of the display area in Unity units

    private GameObject[,] pixelGrid; // 2D array to hold the generated pixel grid

    void Start()
    {
        GeneratePixelGrid();
    }

    void Update()
    {
        // Optional: Add input handling to adjust pixelsPerRow dynamically
    }

    public void GeneratePixelGrid()
    {
        // Clean up old pixels if any exist
        if (pixelGrid != null)
        {
            foreach (GameObject pixel in pixelGrid)
            {
                Destroy(pixel);
            }
        }

        // Calculate spacing based on the display size and pixel density
        float spacing = displaySize / pixelsPerRow;
        pixelGrid = new GameObject[pixelsPerRow, pixelsPerRow];

        for (int i = 0; i < pixelsPerRow; i++)
        {
            for (int j = 0; j < pixelsPerRow; j++)
            {
                Vector3 position = new Vector3(i * spacing, j * spacing, 0) - (Vector3.one * displaySize / 2) + (Vector3.one * spacing / 2);
                // Corrected Instantiate call with explicit cast to GameObject
                GameObject pixel = (GameObject)Instantiate(pixelPrefab, position, Quaternion.identity);
                pixel.transform.localScale = Vector3.one * spacing; // Adjust scale to match spacing
                pixel.transform.parent = transform; // Set parent after instantiation
                pixelGrid[i, j] = pixel;
            }
        }

    }

    // Optional: Implement a method to adjust pixel density and regenerate the grid
}
