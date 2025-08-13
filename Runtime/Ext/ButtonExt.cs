using UnityEngine.Events;
using UnityEngine.UI;

namespace MyLib.Ext
{
    public static class ButtonExt
    {
        public static void UpdateListener(this Button button, UnityAction action)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(action);
        }
        
        public static void RemoveAllListeners(this Button button)
        {
            button.onClick.RemoveAllListeners();
        }
        
        public static void AddListener(this Button button, UnityAction action)
        {
            button.onClick.AddListener(action);
        }
        
        public static void RemoveListener(this Button button, UnityAction action)
        {
            button.onClick.RemoveListener(action);
        }
    }
}