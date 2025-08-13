using UnityEngine;

public static class TransformExt 
{
   public static void Clear(this Transform transform)
   {
      foreach (Transform child in transform)
      {
         Object.Destroy(child.gameObject);
      }
   }
}
