using Unity.Burst;
using Unity.Entities;

[UpdateInGroup(typeof(SimulationSystemGroup))]
public partial class SpawnerSystem_FromEntity : SystemBase
{
    BeginInitializationEntityCommandBufferSystem _commandBufferSystem;

    protected override void OnCreate()
        => _commandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();

    protected override void OnUpdate()
    {
        var commandBuffer = _commandBufferSystem.CreateCommandBuffer();

        Entities
            .WithName("SpawnerSystem_FromEntity")
            .WithBurst(FloatMode.Default, FloatPrecision.Standard, true); 
            //.ForEach((Entity entity, int entityInQueryIndex, in ) =>)
    }
}
