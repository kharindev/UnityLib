using UnityEngine;

namespace MyLib.Ext
{
    public static class Vector2Ext
    {
        public static Vector2 SetReturn(this Vector2 v2, float x, float y)
        {
            v2.Set(x, y);
            return v2;
        }
    }
}
