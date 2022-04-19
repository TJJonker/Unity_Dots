using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public partial class RotationSpeed_System : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities
            .WithName("RotationSpeed_Data")
            .ForEach((ref Rotation rotation, in RotationSpeed_Data rotationSpeed) =>
            {
            rotation.Value = math.mul(
                math.normalize(rotation.Value),
                quaternion.AxisAngle(math.forward(), rotationSpeed.RadiansPerSecond * deltaTime)); 
            })
            .ScheduleParallel();
    }
}
