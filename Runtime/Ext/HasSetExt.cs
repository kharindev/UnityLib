
using System.Collections.Generic;

namespace MyLib.Ext
{
    public static class HasSetExt 
    {
        public static bool CheckAdd<T>(this HashSet<T> list, T obj)
        {
            if(list.Contains(obj)) return false;
            list.Add(obj);
            return true;
        }
    
        public static bool CheckRemove<T>(this HashSet<T> list, T obj)
        {
            if(!list.Contains(obj)) return false;
            list.Remove(obj);
            return true;
        }
    }
}
