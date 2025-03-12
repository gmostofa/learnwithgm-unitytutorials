using System;
using UnityEngine;

public class MonobehaviourExample : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
        GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
        GetComponent<Renderer>().material.color = Color.white;
    }
}
