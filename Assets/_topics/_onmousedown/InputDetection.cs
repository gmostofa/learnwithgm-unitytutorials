using System;
using UnityEngine;

public class InputDetection : MonoBehaviour
{
   public LayerMask layerMask;
   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         DetectObject();
      }
   }

   private void DetectObject()
   {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if (Physics.Raycast(ray, out RaycastHit hitInfo, 1000, layerMask))
      {
         Debug.Log(hitInfo.collider.name);
      }
   }
}
