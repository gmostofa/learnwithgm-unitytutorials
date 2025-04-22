using System;
using UnityEngine;

public class TagSample : MonoBehaviour
{
   public GameObject[] myTagObject;

   private void Start()
   {
      myTagObject = GameObject.FindGameObjectsWithTag("mytag");
   }
}
