using UnityEngine;

public class HolographicDisplay : MonoBehaviour
{
    public float displaySize;
    public int resolutionX;
    public int resolutionY;

    // Function to return a string description of the display
    public string Describe()
    {
        return "Holographic Display - Size: " + displaySize + " inches, Resolution: " + resolutionX + "x" + resolutionY;
    }
}
