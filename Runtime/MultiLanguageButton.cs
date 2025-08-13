using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace MyLib
{
   public class MultiLanguageButton : MonoBehaviour
   {
      public List<string> languages;
      public List<Sprite> flags;
      public Image icon;
      public Button button;
      public string currentLanguage;
      public event Action<string> OnLanguageChanged;
      public void ButtonListener()
      {
         var index = languages.IndexOf(currentLanguage)+1;
         if (index == languages.Count) index = 0;
         currentLanguage = languages[index];
         SetLanguage(index);
         OnLanguageChanged?.Invoke(currentLanguage);
      }
      private void SetLanguage(int index)
      {
         var flag = flags[index];
         icon.sprite = flag;
      }
      
      public void SetLanguage(string key)
      {
         var index = languages.IndexOf(key);
         var flag = flags[index];
         icon.sprite = flag;
         currentLanguage = key;
      }
   }
}
