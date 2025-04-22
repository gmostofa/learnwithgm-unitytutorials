using UnityEngine;

public class DoWhileLoopExample : MonoBehaviour
{
    void Start()
    {
        int count = 5;

        do
        {
            Debug.Log("Do-While Iteration: " + count);
            count++; 
        }
        while (count < 3);
    }
}