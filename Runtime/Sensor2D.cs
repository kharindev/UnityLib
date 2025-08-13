using System;
using MyLib.Ext;
using UnityEngine;

namespace MyLib
{
    public class Sensor2D<T> : MonoBehaviour where T : Component
    {
        public ComponentLocation componentLocation;
        public event Action<T> OnSensorEnterAction;
        public event Action<T> OnSensorExitAction;
        private void OnTriggerEnter2D(Collider2D other)
        {
            var t = other.GetSmartComponent<T>(componentLocation);
            if (!t) return;
            OnSensorEnterAction?.Invoke(t);
            OnSensorEnter(t);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            var t = other.GetSmartComponent<T>(componentLocation);
            if (!t) return;
            OnSensorExitAction?.Invoke(t);
            OnSensorExit(t);
        }
        

        public virtual void OnSensorEnter(T t)
        {
        
        }
        
        public virtual void OnSensorExit(T t)
        {
        
        }
    }

    public enum ComponentLocation
    {
        Standard,
        Parent,
        Children
    }
}

