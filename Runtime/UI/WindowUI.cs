using System;
using MyLib.UI;
using UnityEngine;

public class WindowUI : MonoBehaviour
{
   public bool needPause = true;
   public bool IsActive { get; set; }
   public event Action OnShow;
   public event Action OnHide;

   public virtual void Show()
   {  
      gameObject.SetActive(true);
      IsActive = true;
      OnShow?.Invoke();
      if(needPause) 
         WindowUIManager.AddWindow(this);
   }

   public virtual void Hide()
   {
      gameObject.SetActive(false);
      IsActive = false;
      OnHide?.Invoke();
      if(needPause) 
         WindowUIManager.RemoveWindow(this);
   }
}


