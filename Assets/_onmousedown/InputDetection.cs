using System;
using UnityEngine;

public class InputDetection : MonoBehaviour
{
   private void Update()
   {
       if (Input.GetKey(KeyCode.A))
       {
           Debug.Log("A");
       }
   }
}
