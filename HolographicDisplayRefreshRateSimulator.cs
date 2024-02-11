using UnityEngine;

public class HolographicDisplayRefreshRateSimulator : MonoBehaviour
{
    public Material displayMaterial; // The material representing the holographic display
    public Texture[] textures; // An array of textures to cycle through, simulating pixel updates
    public float refreshRate = 1f; // Refresh rate in Hz, how often to update the texture per second

    private float updateInterval; // Time between updates, derived from the refresh rate
    private int currentTextureIndex = 0; // Current index in the textures array
    private float timer = 0f; // Timer to track update intervals

    void Start()
    {
        if (textures.Length > 0)
        {
            updateInterval = 1f / refreshRate;
        }
        else
        {
            Debug.LogError("Textures array is empty. Please assign textures in the inspector.");
        }
    }

    void Update()
    {
        if (textures.Length == 0) return;

        timer += Time.deltaTime;
        if (timer >= updateInterval)
        {
            // Update the material's texture
            displayMaterial.mainTexture = textures[currentTextureIndex];

            // Cycle through the textures array
            currentTextureIndex = (currentTextureIndex + 1) % textures.Length;

            // Reset the timer
            timer = 0f;
        }
    }
}
