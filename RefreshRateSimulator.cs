using System.Collections;
using UnityEngine;

public class RefreshRateSimulator : MonoBehaviour
{
    public RotatingObject rotatingObject;
    [Tooltip("Simulated refresh rate in Hz")]
    public float refreshRate = 30.0f; // Default refresh rate

    // Corrected: Replace expression-bodied member with a method
    private float UpdateInterval()
    {
        return 1.0f / refreshRate;
    }

    private Coroutine refreshRoutine;

    void Start()
    {
        if (rotatingObject != null)
        {
            StartRefreshRoutine();
        }
    }

    void OnValidate()
    {
        // Adjust the coroutine based on the new refresh rate if it's already running
        if (refreshRoutine != null)
        {
            StopCoroutine(refreshRoutine);
            StartRefreshRoutine();
        }
    }

    void StartRefreshRoutine()
    {
        refreshRoutine = StartCoroutine(RefreshRoutine());
    }

    IEnumerator RefreshRoutine()
    {
        while (true)
        {
            rotatingObject.transform.Rotate(Vector3.up, rotatingObject.rotationSpeed * UpdateInterval());
            yield return new WaitForSeconds(UpdateInterval());
        }
    }
}
