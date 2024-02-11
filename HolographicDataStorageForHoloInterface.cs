using UnityEngine;

public class HolographicDataStorageForHoloInterface : MonoBehaviour
{
    public int storageCapacity; // Example property

    // Implement the Describe method
    public string Describe()
    {
        return "Holographic Data Storage - Capacity: " + storageCapacity + " TB";
    }
}
