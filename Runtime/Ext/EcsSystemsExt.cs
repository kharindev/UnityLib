
using Leopotam.Ecs;
public static class EcsSystemsExt 
{
    public static EcsSystems AddInject(this EcsSystems ecsSystems, IEcsSystem system)
    {
        ecsSystems.Add(system).Inject(system);
        return ecsSystems;
    }
}
