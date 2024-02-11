using UnityEngine;
using System.Collections.Generic;

public class NetworkManager : MonoBehaviour
{
    public List<NetworkNode> nodesInNetwork = new List<NetworkNode>();
    public ANNController annController;

    void Start()
    {
        // Initialize the network, nodes, and ANN here
        // Assuming nodes and ANN are manually assigned in the editor for simplicity
        // In a real application, you might dynamically discover or add nodes
    }

    // Call this method to add a new node to the network dynamically
    public void AddNode(NetworkNode newNode)
    {
        if (!nodesInNetwork.Contains(newNode))
        {
            nodesInNetwork.Add(newNode);
            Debug.Log("Node added: " + newNode.nodeID);
            // Optionally, update ANN or network topology here
        }
        else
        {
            Debug.LogError("Node already exists in the network.");
        }
    }

    // Call this method to remove a node from the network
    public void RemoveNode(NetworkNode node)
    {
        if (nodesInNetwork.Contains(node))
        {
            nodesInNetwork.Remove(node);
            Debug.Log("Node removed: " + node.nodeID);
            // Optionally, update ANN or network topology here
        }
        else
        {
            Debug.LogError("Node does not exist in the network.");
        }
    }

    // Simulate data transmission across the network
    public void SimulateNetworkActivity()
    {
        foreach (var node in nodesInNetwork)
        {
            node.SendData();
        }
    }

    // Example method to update ANN based on network changes
    // Placeholder for where you might integrate more complex ANN logic
    public void UpdateANN()
    {
        // Placeholder: Implement ANN training or topology update logic here
        Debug.Log("ANN updated based on current network topology.");
    }
}
