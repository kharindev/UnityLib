
using System;
using System.Collections.Generic;


public static class ListExt
{
    private static Random random = new Random();
    
    public static T Random<T>(this List<T> list, int offset = 0)
    {
        return list[random.Next(0, list.Count-offset)];
    }
    
    public static T RandomWithOffsets<T>(this List<T> list, int offsetMin = 0, int offsetMax = 0)
    {
        return list[random.Next(offsetMin, list.Count-offsetMax)];
    }

    public static void Shake<T>(this List<T> list)
    {
        list.Sort((x, y) => random.Next(-1, 2)); 
    }
    
    public static void CheckAdd<T>(this List<T> list, T obj)
    {
        if(list.Contains(obj)) return;
        list.Add(obj);
    }
    
    public static void CheckRemove<T>(this List<T> list, T obj)
    {
        if(!list.Contains(obj)) return;
        list.Remove(obj);
    }
}
