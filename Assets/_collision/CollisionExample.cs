using System;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + "Entered");
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject.name + " is stay");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(other.gameObject.name + "Exit");
    }
}
