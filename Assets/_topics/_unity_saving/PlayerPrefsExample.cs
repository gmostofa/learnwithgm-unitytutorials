using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsExample : MonoBehaviour
{
   public Button saveButton;
   public TMP_InputField valueInput;
   public TextMeshProUGUI valueText;


   private void Start()
   {
      LoadData();
      saveButton.onClick.AddListener(SaveData);
   }


   public void SaveData()
   {
      PlayerPrefs.SetString("anything_you_want_as_a_key", valueInput.text);
      PlayerPrefs.Save();
      Debug.Log($"You saved {valueInput.text}");
   }

   public void LoadData()
   {
      string loadValue = PlayerPrefs.GetString("anything_you_want_as_a_key");
      valueText.text = loadValue;
   }
}
