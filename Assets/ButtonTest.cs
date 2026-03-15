using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
   public Button ourButton;
   public GameObject ourCube;
   

   private void Start()
   {
      ourButton.onClick.AddListener((() =>
      {
         
      }));
   }

   public void ButtonFunction()
   {
      ourCube.SetActive(false);
   }
}
