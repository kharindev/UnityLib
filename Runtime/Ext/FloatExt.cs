using UnityEngine;

public static class FloatExt 
{
    public static bool Roll(this float chance)
    {
        return Random.Range(0, 100) <= chance;
    }
}
