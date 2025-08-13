using Leopotam.Ecs;
using UnityEngine;

public class TimerSystem : IEcsRunSystem
{
    private EcsFilter<TimerComponent> _timers;
    private EcsFilter<DestroyTimerComponent> _destroyTimers;
    
    public void Run()
    {
        foreach (var it in _timers)
        {
            ref var timer = ref _timers.Get1(it);
            timer.Value -= Time.deltaTime;
            if(timer.Value <= 0) _timers.GetEntity(it).Del<TimerComponent>();
        }  
        
        foreach (var it in _destroyTimers)
        {
            ref var timer = ref _destroyTimers.Get1(it);
            timer.Value -= Time.deltaTime;
            if (timer.Value <= 0)
            {
                _destroyTimers.GetEntity(it).Get<DestroyRequest>();
                _destroyTimers.GetEntity(it).Del<DestroyTimerComponent>();
            }
        } 
    }
}

public struct TimerComponent
{
    public float Value;
    public float Max;
}

public struct DestroyTimerComponent
{
    public float Value;
}

public struct DestroyRequest : IEcsIgnoreInFilter
{
}
