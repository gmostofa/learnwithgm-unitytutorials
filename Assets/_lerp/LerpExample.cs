using UnityEngine;


public class LerpExample : MonoBehaviour {
    public float lerpTime = 1f;
    public float currentLerpTime;
 
    public float moveDistance = 10f;
 
    public Vector3 startPos;
    public Vector3 endPos;
 
    protected void Start() 
    {
        startPos = transform.position;
        endPos = transform.position + transform.up * moveDistance;
    }
 
    protected void Update() 
    {
        //reset when we press spacebar
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            currentLerpTime = 0f;
        }
 
        //increment timer once per frame
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime) 
        {
            currentLerpTime = lerpTime;
        }
 
        //lerp!
       // float perc = currentLerpTime / lerpTime;
       float t = currentLerpTime / lerpTime;
       //t = Mathf.Sin(t * Mathf.PI * 0.5f);
       t = t * t * (3f - 2f * t);
        transform.position = Vector3.Lerp(startPos, endPos, t);
        
       
    }
}