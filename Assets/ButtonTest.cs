using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
   public Button ourButton;
   public GameObject ourCube;
   

   private void Start()
   {
      ourButton.onClick.AddListener(() => {
            Debug.Log("Button is pressed");
            ourCube.SetActive(false);
         }
      );
   }
}
