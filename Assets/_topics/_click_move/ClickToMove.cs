using System;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
   private Vector3 targetPosition;
   public float moveSpeed;

   private void Start()
   {
      targetPosition = transform.position;
   }

   private void Update()
   {
      if(Input.GetMouseButtonDown(0))
      {
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if (Physics.Raycast(ray, out RaycastHit hit))
         {
            targetPosition = hit.point;
         }
      }

      transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
   }
}