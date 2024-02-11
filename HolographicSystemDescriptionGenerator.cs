using UnityEngine;
using System.Text;

public class HolographicSystemDescriptionGenerator : MonoBehaviour
{
    public HolographicDisplay holographicDisplay;
    public HolographicDataStorageForHoloInterface HolographicDataStorageForHoloInterface;
    public HolographicInterface holographicInterface;

    // Generates a comprehensive description of the holographic system
    public string GenerateDescription()
    {
        StringBuilder description = new StringBuilder();
        description.AppendLine("Holographic System Description:");
        description.AppendLine(holographicDisplay.Describe());
        description.AppendLine(HolographicDataStorageForHoloInterface.Describe());
        description.AppendLine(holographicInterface.Describe());

        return description.ToString();
    }

    // Example usage
    void Start()
    {
        Debug.Log(GenerateDescription());
    }
}
