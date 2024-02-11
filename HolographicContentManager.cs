using UnityEngine;

public class HolographicContentManager : MonoBehaviour
{
    [Tooltip("Array of GameObjects representing holographic content")]
    public GameObject[] holographicContents;

    [Tooltip("Interval in seconds at which to change content")]
    public float changeInterval = 5.0f;

    private int currentIndex = 0; // Tracks the current content index
    private float timer = 0f; // Timer to track the interval

    void Start()
    {
        InitializeContentVisibility();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeInterval)
        {
            CycleContent();
            timer = 0f; // Reset timer after each cycle
        }
    }

    // Initialize content visibility: show the first and hide the rest
    private void InitializeContentVisibility()
    {
        if (holographicContents.Length == 0) return;

        // Loop through all contents
        for (int i = 0; i < holographicContents.Length; i++)
        {
            // Activate the first item and deactivate all others
            holographicContents[i].SetActive(i == 0);
        }
    }

    // Cycles to the next piece of content in the array
    private void CycleContent()
    {
        // Deactivate current content
        holographicContents[currentIndex].SetActive(false);

        // Move to the next content, looping back to the start if at the end
        currentIndex = (currentIndex + 1) % holographicContents.Length;

        // Activate new current content
        holographicContents[currentIndex].SetActive(true);
    }
}
