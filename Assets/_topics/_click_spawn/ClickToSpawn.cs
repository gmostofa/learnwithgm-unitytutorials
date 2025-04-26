using System;
using UnityEngine;

public class ClickToSpawn : MonoBehaviour
{
   public GameObject spawnedObject;
   public float offsetValue = 0.5f;

   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if (Physics.Raycast(ray, out RaycastHit hit))
         {
            Vector3 spawnPosition = hit.point + (Vector3.up * offsetValue);
            Instantiate(spawnedObject, spawnPosition, Quaternion.identity);
         }
      }
   }
}