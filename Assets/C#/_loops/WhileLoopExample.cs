using UnityEngine;

public class WhileLoopExample : MonoBehaviour
{
    void Start()
    {
        int count = 5;

        // Loop until count reaches 3
        while (count < 3)
        {
            Debug.Log("While Loop Iteration: " + count);
            count++; // Increment count
        }
    }
}