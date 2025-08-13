using System;
using UnityEngine;

public class SaveService 
{
    public static Action SaveAction;
    private static float _timer;
    private static float _saveTime;
    private static bool _isSaved = true;
    private static float _cooldownTimer;
    private static float _cooldown = 1f;

    public static bool ForceMode { get; set; } = false;
    public static void Init(float saveDelay)
    {
        _saveTime = saveDelay;
    }
    
    public static void Save(float time)
    {
        _isSaved = false;
        _timer = time;
    }
    

    public static void Save()
    {
        if (ForceMode)
        {
            SaveForce();
        }
        else
        {
            Save(_saveTime); 
        }
    }

    public static void SaveForce()
    {
        if (_cooldownTimer <= 0)
        {
            SaveAction?.Invoke();
        }
        _isSaved = true;
    }

    public static void Update()
    {
        if (_cooldownTimer <= 0)
        {
            if (_isSaved) return;
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                SaveForce();
            }
        }
        else
        {
            _cooldownTimer -= Time.deltaTime;
        }
    }
    
    public static void SetDelay()
    {
        _cooldownTimer = _cooldown;
    }

    public static void Dispose()
    {
        SaveAction = null;
    }
}