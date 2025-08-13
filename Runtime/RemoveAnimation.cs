using UnityEngine;

public class RemoveAnimation : MonoBehaviour
{
    public bool isPooled;
    private AnimationEventListener _listener;

    private void Awake()
    {
        _listener = GetComponent<AnimationEventListener>();
    }

    private void OnEnable()
    {
        _listener.OnAnimationEvent += ListenerOnOnAnimationEvent;
    }
    
    private void OnDisable()
    {
        _listener.OnAnimationEvent -= ListenerOnOnAnimationEvent;
    }

    private void ListenerOnOnAnimationEvent(string eve)
    {
        if (eve.Contains("RemoveEvent"))
        {
            if (isPooled)
            {
                Pools.Release(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
