using UnityEngine;

public class FirstScript : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(EaseInSine(transform.position.x),0,0) * Time.deltaTime;
    }
    
    float EaseInSine(float x)
    {
        return 1 - Mathf.Cos((x * Mathf.PI) / 2);
    }
}
