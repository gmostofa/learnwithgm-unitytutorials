using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeExample : MonoBehaviour
{
   [Header("Header")] 
   public float var1;

   [Space(20)] public string afterSpace;
   
   [Range(0,10)] public int rangeVariable;

   [Tooltip("this is tooltip")] public int tool;

}
