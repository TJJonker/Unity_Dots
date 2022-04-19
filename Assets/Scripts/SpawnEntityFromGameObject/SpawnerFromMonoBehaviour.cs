using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[AddComponentMenu("DOTS Samples/Spawner")]
public class SpawnerFromMonoBehaviour : MonoBehaviour
{
    [SerializeField]
    public GameObject Prefab;
    public int CountX = 10;
    public int CountY = 10;

    private void Start()
    {
        var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
        var prefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(Prefab, settings);
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        
        for(int x = 0; x < CountX; x++)
        {
            for(int y = 0; y < CountY; y++)
            {
                var instance = entityManager.Instantiate(prefab);

                var position = transform.TransformPoint(new float3(x, y, 0));
                entityManager.SetComponentData(instance, new Translation { Value = position });
            }
        }
    }
}
