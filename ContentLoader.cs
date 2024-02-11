using UnityEngine;

public class ContentLoader : MonoBehaviour
{
    public HolographicPregenerationManager pregenerationManager;

    // Example method to load a holographic model
    public void LoadHolographicModel(string modelId)
    {
        float modelPregenerationTime = 3.0f; // Example wait time
        pregenerationManager.PregenerateContent(modelId, modelPregenerationTime);
    }
}
