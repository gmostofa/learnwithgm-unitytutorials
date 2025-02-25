using UnityEngine;
using System.Collections.Generic;

public class ForeachLoopExample : MonoBehaviour
{
    void Start()
    {
        List<string> players = new List<string>() { "Alice", "Bob", "Charlie" };

        // Loop through each player
        foreach (string player in players)
        {
          //  Debug.Log("Player: " + player);
        }

        foreach (var t in players)
        {
            Debug.Log("Player: " + t);
        }
    }
}