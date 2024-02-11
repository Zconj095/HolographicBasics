using UnityEngine;
using System.Collections.Generic;

public class NetworkNode : MonoBehaviour
{
    public ANNController annController;
    public List<int> connectedNodes = new List<int>(); // List of connected node IDs
    public int nodeID;

    // Method to simulate sending data to another node
    public void SendData()
    {
        int nextNode = annController.DetermineNextNode(connectedNodes, nodeID);
        Debug.Log("Node " + nodeID + " sending data to Node " + nextNode);
        // Additional logic to send data would go here
    }
}
