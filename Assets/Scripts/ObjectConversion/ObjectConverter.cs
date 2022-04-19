using Unity.Entities;
using UnityEngine;

public class ObjectConverter : MonoBehaviour
{
    public GameObject objectGO;

    private Entity objectEnt;
    private BlobAssetStore blobAssetStore;

    private void Awake()
    {
        blobAssetStore = new BlobAssetStore();
        GameObjectConversionSettings settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, blobAssetStore);
        objectEnt = GameObjectConversionUtility.ConvertGameObjectHierarchy(objectGO, settings);
        Destroy(objectGO);
    }

    private void OnDestroy() => blobAssetStore.Dispose();
}
