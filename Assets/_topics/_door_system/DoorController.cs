using System;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90;
    public float speed = 2f;
    
    private Quaternion closedRotation;
    private Quaternion openRotation;
    
    private bool isOpen = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(0, openAngle, 0) * closedRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * speed);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, closedRotation, Time.deltaTime * speed);
        }
    }

    public void ToggleDoor()
    {
        isOpen = !isOpen;
    }
}
