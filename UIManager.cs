using UnityEngine;

public class UIManager : MonoBehaviour
{
    public HolographicImageGenerator holographicGenerator;
    public string imagePath = "path/to/image.file";

    public void OnGenerateButtonClick()
    {
        holographicGenerator.GenerateHolographicImage(imagePath);
    }
}
