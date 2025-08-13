using TMPro;
using UnityEngine;

public class MessageUI : WindowUI
{
    [SerializeField] private TextMeshProUGUI messageLabel;
    [SerializeField] private Animator animator;
    private static readonly int ShowTrigger = Animator.StringToHash("Show");
    private static readonly int HideTrigger = Animator.StringToHash("Hide");

    public void Show(string message)
    {
        messageLabel.SetText(message);
        base.Show();
        animator.SetBool(ShowTrigger, true);
    }

    public void UpdateMessageText(string message)
    {
        messageLabel.SetText(message);
    }

    public override void Hide()
    {
        animator.SetBool(ShowTrigger, false);
    }
}
