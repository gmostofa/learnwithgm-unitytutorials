using UnityEngine;

public class FunctionTut : MonoBehaviour
{
    void Start()
    {
        TestName();
        Debug.Log(Sum(3,4));
        Debug.Log(Sum(10,20));
        Debug.Log(Sum(50,60));
    }
    

    private void TestName()
    {
        Debug.Log("Hello World!");
    }

    private int Sum(int a, int b)
    {
        int sum = 0;
        sum = a + b;
        
        return sum;
    }
}
