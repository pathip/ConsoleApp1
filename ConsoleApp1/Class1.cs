using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02
{
    class pyramid
    {
        public static float calpyra(float a, float b)
        {
            return (float)(0.3 * a * b);
        }
    }

    class Diamond
    {
        public static float caldia(float a, float b)
        {
            return (float)(0.5 * (a * b));
        }
    }

    class square
    {
        public static float calsqu(float a)
        {
            return a * a;
        }
    }
}
