using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Pool
{
    private static GameObject poolRoot;
    private static string PoolRootKey = "PoolRoot";
    
    private GameObject prefab;
    public Transform root;
    private int activeCount = 0;
    private Queue<GameObject> content = new Queue<GameObject>();
    protected int maxCapacity = 100;
    public float maxTime = 5*60;
    public float timer;
        
    public Pool(GameObject prefab)
    {
        this.prefab = prefab;
        this.maxCapacity = 1000;
        this.root = new GameObject(prefab.name).transform;

        if (!poolRoot)
        {
            poolRoot = GameObject.Find(PoolRootKey);
            if(!poolRoot) poolRoot = new GameObject(PoolRootKey);
        }
        
        this.root.SetParent(poolRoot.transform);
            
        UpdateCountLabel();
        ResetTimer();
    }

    private void ResetTimer()
    {
        timer = maxTime;
    }
    
    public void Update()
    {
        if(timer <= 0) return;
        timer -= Time.deltaTime;
        if (timer <= 0) Clear();
    }

    public GameObject Get(Action<GameObject> beforeReset = null)
    {
        GameObject result;
        if (content.Count == 0)
            result = Object.Instantiate(prefab, root);
        else
            result = content.Dequeue();
        beforeReset?.Invoke(result);
        result.gameObject.SetActive(true);
        AddCount();
        ResetTimer();
        return result;
    }
    
    public void Release(GameObject what)
    {
        if (content.Count == maxCapacity)
        {
	        Object.Destroy(what.gameObject);
            DecCount();
        }
        else if(!content.Contains(what))
        {
	        content.Enqueue(what);
            what.gameObject.SetActive(false);
            what.transform.SetParent(root);
            DecCount();
        }
        else
        {
	        // Debug.Log("пул уже содержит данный обьект");
        }
    }

    private void UpdateCountLabel()
    {
        root.name = prefab.name + activeCount + "/" + content.Count;
    }

    public string GetStatsString()
    {
	    return prefab.name + activeCount + "/" + content.Count;
    }
        
    private void DecCount()
    {
        activeCount--;
        UpdateCountLabel();
    }
    
    private void AddCount()
    {
        activeCount++;
        UpdateCountLabel();
    }

    public void Clear()
    {
        foreach (var go in content)
        {
            UnityEngine.Object.Destroy(go);
        }
        content.Clear();
        UpdateCountLabel();
    }
}