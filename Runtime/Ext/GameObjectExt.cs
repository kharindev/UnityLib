using UnityEngine;

namespace MyLib.Ext
{
    public static class GameObjectExt
    {

        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var component = gameObject.GetComponent<T>();
            if (component == null) component = gameObject.AddComponent<T>();
            return component;
        }
        
        public static T GetSmartComponent<T>(this Component component, ComponentLocation location)
        {
            switch (location)
            {
                case ComponentLocation.Parent:
                    return component.GetComponentInParent<T>();
                case ComponentLocation.Children:
                    return component.GetComponentInChildren<T>();
                case ComponentLocation.Standard:
                    return component.GetComponent<T>();
                default:
                    return component.GetComponent<T>();
            }
        }
    
        public static T GetSmartComponent<T>(this GameObject gameObject, ComponentLocation location)
        {
            switch (location)
            {
                case ComponentLocation.Parent:
                    return gameObject.GetComponentInParent<T>();
                case ComponentLocation.Children:
                    return gameObject.GetComponentInChildren<T>();
                case ComponentLocation.Standard:
                    return gameObject.GetComponent<T>();
                default:
                    return gameObject.GetComponent<T>();
            }
        }
    }
}
