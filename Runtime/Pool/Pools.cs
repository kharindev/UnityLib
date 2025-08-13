using System;
using System.Collections.Generic;
using UnityEngine;

public class Pools : MonoBehaviour
{
    public static Dictionary<GameObject, Pool> dict = new Dictionary<GameObject, Pool>();
    public static Dictionary<GameObject, GameObject> prefabToObject = new Dictionary<GameObject, GameObject>();
    public static T Get<T>(GameObject prefab)
    {
        return Get(prefab).GetComponent<T>();
    }
    
    public static GameObject Get(GameObject prefab)
    {
        Pool pool = null;
        if (!dict.ContainsKey(prefab))
        {
            pool = dict[prefab] = new Pool(prefab);
        }
        else
        {
            pool = dict[prefab];
        }

        var pooledObject = pool.Get();
        AddObjectToPrefab(pooledObject, prefab);
        return pooledObject;
    }

    private static void AddObjectToPrefab(GameObject pooledObject, GameObject prefab)
    {
        if(prefabToObject.ContainsKey(pooledObject)) return;
        prefabToObject.Add(pooledObject, prefab);
    }
    private static void RemoveObjectToPrefab(GameObject pooledObject)
    {
        if (prefabToObject.ContainsKey(pooledObject))
        {
            prefabToObject.Remove(pooledObject);
        }
     
    }
    
    private static GameObject PrefabFromObject(GameObject pooledObject)
    {
        return prefabToObject[pooledObject];
    }

    public static void Release(GameObject what)
    {
        var prefab = PrefabFromObject(what);
        if (dict.ContainsKey(prefab))
        {
            dict[prefab].Release(what);
            RemoveObjectToPrefab(prefab);
        }
    }
    
    public static void Release(GameObject prefab, GameObject what)
    {
        if(dict.ContainsKey(prefab)) 
            dict[prefab].Release(what);
    }

    public static void DestroyPool(GameObject prefab)
    {
        dict.Remove(prefab);
    }

    public static void DestroyObjects()
    {
        foreach (var val in dict.Values)
        {
            DestroyImmediate(val.root);
            // foreach (var obj in val.)
            // {
            //     
            // }
        }
        dict.Clear();
    }

    public static void Update()
    {
        foreach (var entry in dict)
        {
            entry.Value.Update();
        }
    }
}
