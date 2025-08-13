using System;

namespace MyLib
{
    [Serializable]
    public class Limit
    {
        public float min;
        public float max;

        public Limit(float min, float max)
        {
            this.min = min;
            this.max = max;
        }
    }
}
