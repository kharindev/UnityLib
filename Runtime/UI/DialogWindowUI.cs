
using System;
using MyLib.Ext;
using MyLib.Translation;
using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class DialogWindowUI : WindowUI
{
    [SerializeField] private TextMeshProUGUI messageLabel;
    [SerializeField] private Button yesButton;
    [SerializeField] private Button noButton;
    public void Show(string msg, Action yesAction = null, Action noAction = null)
    {
        messageLabel.SetText(msg);
        yesButton.UpdateListener(() =>
        {
            yesAction?.Invoke();
            Hide();
        });
        noButton.UpdateListener(() =>
        {
            noAction?.Invoke();
            Hide();
        });
        Show();
    } 
    
    public void ShowTranslate(string key, Action yesAction = null, Action noAction = null)
    {
       Show(Translation.Get(key), yesAction, noAction);
    } 
}
