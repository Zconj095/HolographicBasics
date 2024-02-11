using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    [Tooltip("Rotation speed in degrees per second")]
    public float rotationSpeed = 360.0f; // Default speed

    void Update()
    {
        // Rotate the object around its up axis at the specified speed
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
