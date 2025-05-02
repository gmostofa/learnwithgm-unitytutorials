using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
   public int coinValue;

   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           Debug.Log("Coin collected, Add to inventory : " +coinValue);
           //play a sound
           //particle play here
           //coin animation to inventory
           
           Destroy(this.gameObject);
       }
   }
}
