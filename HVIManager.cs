using UnityEngine;

public class HVIManager : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        // Check for user interaction
        if (Input.GetMouseButtonDown(0)) // Left mouse click
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                HolographicObject holographicObject = hit.transform.GetComponent<HolographicObject>();
                if (holographicObject != null)
                {
                    holographicObject.OnInteract();
                }
            }
        }
    }
}
