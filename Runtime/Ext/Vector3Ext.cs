using UnityEngine;

namespace MyLib
{
    public static class Vector3Ext
    {
        public static Vector2 SetReturn(this Vector3 v3, float x, float y, float z = 0)
        {
            v3.Set(x, y,z);
            return v3;
        }
        
        public static Vector2 SetXReturn(this Vector3 v3, float x)
        {
            v3.Set(x,  v3.y, v3.z);
            return v3;
        }
    }
}