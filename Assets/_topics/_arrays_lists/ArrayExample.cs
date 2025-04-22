using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    void Start()
    {
        // Declare and initialize an array
        int[] scores = new int[5] { 10, 20, 30, 40, 50 };

        // Accessing elements
        Debug.Log("First Score: " + scores[2] + scores.Length);

        // Looping through an array
        foreach (int score in scores)
        {
            Debug.Log("Score: " + score);
        }
    }
}