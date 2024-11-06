using System;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    private void Start()
    {
        int i = 5;

        switch (i)
        {
            case 0:
                Debug.Log("i value is 0");
                break;
            case 1:
                Debug.Log("i value is 1");
                break;
            case 2:
                Debug.Log("i value is 2");
                break;
            
            default:
                Debug.Log("This is default Case");
                break;
        }
    }
}
