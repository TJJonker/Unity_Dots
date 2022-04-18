using Unity.Entities;

[GenerateAuthoringComponent]
public struct RotationSpeed_Data : IComponentData
{
    public float RadiansPerSecond;
}
