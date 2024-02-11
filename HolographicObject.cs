using UnityEngine;

public class HolographicObject : MonoBehaviour
{
    public void OnInteract()
    {
        // Trigger interaction effects
        Debug.Log("Interacted with: " + gameObject.name);
        // Here you can add effects like changing color, playing a sound, or other visual feedback
    }
}
