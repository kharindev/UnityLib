using System.Collections.Generic;
using UnityEngine;

namespace MyLib.UI
{
    public class WindowUIManager : MonoBehaviour
    {
        private static readonly List<WindowUI> OpenedWindows = new List<WindowUI>();
        public static bool HasOpenWindows => OpenedWindows.Count > 0;
    
        public static void AddWindow(WindowUI window)
        {
            if(OpenedWindows.Contains(window)) return;
            OpenedWindows.Add(window);
            GameState.GamePause = true;
        }
    
    
        public static void RemoveWindow(WindowUI window)
        {
            if (!OpenedWindows.Contains(window)) return;
            OpenedWindows.Remove(window);
            if (OpenedWindows.Count == 0) GameState.GamePause = false;
        }
    }
}
   
