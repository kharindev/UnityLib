using MyLib.Ext;
using UnityEngine;

namespace MyLib
{
    public class DebugDraw
    {
        private static Vector2 _tmp;

        public static void DrawRect(Rect rect)
        {
            DrawRect(rect, Color.white, Time.deltaTime);
        }
        
        public static void DrawRect(Rect rect, Color color, float time)
        {
            Debug.DrawLine(_tmp.SetReturn(rect.xMin, rect.yMin), _tmp.SetReturn(rect.xMax, rect.yMin), color, time);
            // Right
            Debug.DrawLine(_tmp.SetReturn(rect.xMax, rect.yMin), _tmp.SetReturn(rect.xMax, rect.yMax), color, time);
            // Bottom
            Debug.DrawLine(_tmp.SetReturn(rect.xMax, rect.yMax), _tmp.SetReturn(rect.xMin, rect.yMax), color, time);
            // Left
            Debug.DrawLine(_tmp.SetReturn(rect.xMin, rect.yMax), _tmp.SetReturn(rect.xMin, rect.yMin), color, time);
        }
        
        public static void DrawRect(float x, float y, float cellSize, Color color, float time)
        {
            // Bottom line
            Debug.DrawLine(_tmp.SetReturn(x, y), _tmp.SetReturn(x + cellSize, y), color, time);
        
            // Right line
            Debug.DrawLine(_tmp.SetReturn(x + cellSize, y), _tmp.SetReturn(x + cellSize, y + cellSize), color, time);

            // Top line
            Debug.DrawLine(_tmp.SetReturn(x + cellSize, y + cellSize), _tmp.SetReturn(x, y + cellSize), color, time);

            // Left line
            Debug.DrawLine(_tmp.SetReturn(x, y + cellSize), _tmp.SetReturn(x, y), color, time);
        }
    }
}
