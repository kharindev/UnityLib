using System;
using UnityEngine;

public class RadialGameLayout : MonoBehaviour
{
    public float distance;
    [Range(0f,360f)]
    public float minAngle, maxAngle, startAngle;
    
    public void CalculateRadial()
    {
        if (transform.childCount == 0)
            return;
        var offsetAngle = (maxAngle - minAngle) / (transform.childCount);
        var angle = startAngle;
        for (var i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            if (!child) continue;
            var position = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad), 0);
            child.localPosition = position * distance;
            angle += offsetAngle;
        }
    }

    public void AddTransform(Transform child)
    {
        child.SetParent(transform, false);
        CalculateRadial();
    }

    private void OnValidate()
    {
        CalculateRadial();
    }
}