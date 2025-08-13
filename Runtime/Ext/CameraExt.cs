using UnityEngine;

namespace MyLib.Ext
{
    public static class CameraExt 
    {
        public static Vector2 ScreenToWorldPoint2D(this Camera camera, Vector2 position)
        {
            return camera.ScreenToWorldPoint(position);
        }
        
        public static Vector2 WorldToScreenPoint2D(this Camera camera, Vector2 position)
        {
            return camera.WorldToScreenPoint(position);
        }
        
        public static Vector2 WorldToViewportPoint2D(this Camera camera, Vector2 position)
        {
            return camera.WorldToViewportPoint(position);
        }
    }
}
