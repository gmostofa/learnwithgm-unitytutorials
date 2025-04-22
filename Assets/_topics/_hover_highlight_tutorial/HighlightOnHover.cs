using System;
using UnityEngine;

public class HighlightOnHover : MonoBehaviour
{
   private Material defaultMaterial;
   public Material hoverMaterial;

   private Renderer ownRenderer;

   private void Start()
   {
      ownRenderer = GetComponent<Renderer>();
      defaultMaterial = ownRenderer.material;
   }


   private void OnMouseEnter()
   {
      ownRenderer.material = hoverMaterial;
   }

   private void OnMouseExit()
   {
      ownRenderer.material = defaultMaterial;
   }
}