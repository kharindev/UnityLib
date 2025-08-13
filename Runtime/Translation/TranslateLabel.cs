using MyLib.Translation;
using TMPro;
using UnityEngine;

public class TranslateLabel : MonoBehaviour, ITranslate
{
   private string _lang = "null";
   public string key;
   private TextMeshProUGUI _label;

   private void OnEnable()
   {
      TranslateProcessor.Add(this);
   }

   private void OnDisable()
   {
      TranslateProcessor.Remove(this);
   }

   public void Translate()
   {
      if (Translation.CurrentLanguageCode == _lang) return;
      if (!_label) _label = GetComponent<TextMeshProUGUI>();
      var translateText = Translation.Get(key);
      _label.SetText(translateText);
      _lang = Translation.CurrentLanguageCode;
   }
}
