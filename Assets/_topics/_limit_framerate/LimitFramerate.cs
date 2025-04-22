using System;
using UnityEngine;

public class LimitFramerate : MonoBehaviour
{
   private void Start()
   {
      Application.targetFrameRate = 20;    
   }
}
