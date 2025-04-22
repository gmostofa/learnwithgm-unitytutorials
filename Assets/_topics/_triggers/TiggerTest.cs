using System;
using UnityEngine;

public class TiggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       Debug.Log($"OnTriggerEnter: {other.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"OnTriggerStay: {other.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"OnTriggerExit: {other.name}");
    }
}
