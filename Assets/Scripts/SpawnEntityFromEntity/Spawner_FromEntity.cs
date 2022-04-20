using Unity.Entities;

public struct Spawner_FromEntity : IComponentData
{
    public int CountX;
    public int CountY;
    public Entity Prefab;
}
