

using UnityEngine;

namespace MyLib
{
    public class MyDebug
    {
        private bool _enable;
        private string _tag;

        public MyDebug(bool enable, string tag)
        {
            _enable = enable;
            _tag = tag;
        }
        public void Log(string message)
        {
            if (_enable)
            {
                Debug.Log(_tag+":"+message);
            }
        }

        public bool IsEnable => _enable;
    }
}
