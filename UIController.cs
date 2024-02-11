using UnityEngine;

public class UIController : MonoBehaviour
{
    public HolographicSystemUpdater holographicUpdater;

    // Example method called when the user selects a new holographic content to display
    public void OnContentSelectionChanged(string newContentFileId)
    {
        holographicUpdater.UpdateDigitalFile(newContentFileId);
    }
}
