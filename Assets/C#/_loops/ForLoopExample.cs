using UnityEngine;

public class ForLoopExample : MonoBehaviour
{
    void Start()
    {
        // Loop from 1 to 5
        for (int i = 1; i <= 5; i++)
        {
            Debug.Log("Iteration: " + i);
        }
    }
}