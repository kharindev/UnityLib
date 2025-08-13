using UnityEngine;

namespace MyLib.Ext
{
    public static class CanvasExt
    {
        private static readonly Vector2 _tmp = new Vector2();
        public static Vector2 WorldToCanvasPosition2D(this RectTransform canvasRect, Vector2 viewportPosition)
        {
            var sizeDelta = canvasRect.sizeDelta;
            return _tmp.SetReturn(
                ((viewportPosition.x*sizeDelta.x)-(sizeDelta.x*0.5f)),
                ((viewportPosition.y*sizeDelta.y)-(sizeDelta.y*0.5f)));
        }
    }
}
