using System;
using DG.Tweening;
using UnityEngine;

public class Coin : MonoBehaviour
{
   public int coinValue;

   public float flotDistance = 0.5f;
   public float floatDuration = 0.5f;
   public float rotateSpeed = 90f;
   public float pulseScale = 1.1f;
   public float pulseDuration = 0.5f;

   public float coinDisappearDuration = 0.2f;
   

   private void Start()
   {
       transform.DOMoveY(transform.position.y + flotDistance, floatDuration)
           .SetLoops(-1, LoopType.Yoyo)
           .SetEase(Ease.InOutFlash);
       
       transform.DORotate(new Vector3(0, 360,0), 2f, RotateMode.FastBeyond360)
           .SetLoops(-1)
           .SetEase(Ease.Linear);

       transform.DOScale(pulseScale, pulseDuration)
           .SetLoops(-1, LoopType.Yoyo)
           .SetEase(Ease.InOutBounce);
   }


   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           Debug.Log("Coin collected, Add to inventory : " +coinValue);
           //play a sound
           //particle play here
           //coin animation to inventory

           GetComponent<Collider>().enabled = false;
           
           transform.DOScale(Vector3.zero, coinDisappearDuration)
               .SetEase(Ease.InBack)
               .onComplete += () => Destroy(gameObject);
           
           
           //Destroy(this.gameObject);
       }
   }
}
