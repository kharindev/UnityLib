using System;
using UnityEngine;

public class AnimationEventListener : MonoBehaviour
{
    public event Action<string> OnAnimationEvent;

    public void ExecuteEvent(string eventName)
    {
        OnAnimationEvent?.Invoke(eventName);
    }
}
