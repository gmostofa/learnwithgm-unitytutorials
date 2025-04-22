using UnityEngine;
using System.Collections.Generic;

public class ListExample : MonoBehaviour
{
    void Start()
    {
        // Declare and initialize a List
        List<string> playerNames = new List<string>() { "Alice", "Bob", "Charlie" };
        

        // Add elements dynamically
        playerNames.Add("David");
        playerNames.Add("Eve");
       

        // Accessing elements
       // Debug.Log("First Player: " + playerNames[0]);

        // Removing an element
        playerNames.Remove("Bob");

        // Looping through a List
        foreach (string name in playerNames)
        {
            Debug.Log("Player: " + name);
        }
    }
}