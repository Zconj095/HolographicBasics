using UnityEngine;

public class HolographicInterface : MonoBehaviour
{
    public string interfaceType; // Example property

    public string Describe()
    {
        return "Holographic Interface - Type: " + interfaceType;
    }
}
