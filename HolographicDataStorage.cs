using UnityEngine;
using System.Collections.Generic;

public class HolographicDataStorage : MonoBehaviour
{
    // Simulated database of holographic data
    private Dictionary<int, string> holographicData = new Dictionary<int, string>();

    void Start()
    {
        // Example of storing some data
        StoreData(1, "Data for Hologram 1");
        StoreData(2, "Data for Hologram 2");
    }

    public void StoreData(int id, string data)
    {
        if (!holographicData.ContainsKey(id))
        {
            holographicData.Add(id, data);
            Debug.Log("Data stored for ID: " + id);
        }
        else
        {
            Debug.LogError("Data for this ID already exists.");
        }
    }

    public string RetrieveData(int id)
    {
        if (holographicData.ContainsKey(id))
        {
            return holographicData[id];
        }
        else
        {
            Debug.LogError("No data found for ID: " + id);
            return null;
        }
    }
}
