using UnityEngine;

public class HolographicPixelSizeSimulator : MonoBehaviour
{
    public Renderer targetRenderer; // Assign the GameObject's Renderer to apply textures
    public Texture[] texturesByResolution; // Assign textures in order of increasing resolution
    [Range(1, 100)]
    public int pixelSize = 50; // Simulated pixel size in micrometers (μm)

    private int currentTextureIndex;

    void Update()
    {
        // Calculate the texture index based on the simulated pixel size
        // This is a simple mapping - you might want to create a more sophisticated mapping based on your needs
        int textureIndex = Mathf.Clamp(pixelSize / 20 - 1, 0, texturesByResolution.Length - 1);

        if (textureIndex != currentTextureIndex)
        {
            // Apply the texture corresponding to the current simulated pixel size
            targetRenderer.material.mainTexture = texturesByResolution[textureIndex];
            currentTextureIndex = textureIndex;
        }
    }
}
