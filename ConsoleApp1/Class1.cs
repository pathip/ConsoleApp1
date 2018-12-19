using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02
{
    class pyramid
    {
        public static float AreaPyramid(float width, float height)
        {
            return (float)(0.3 * width * height);
        }
    }

    class Diamond
    {
        public static float AreaDiamond(float width, float height)
        {
            return (float)(0.5 * (width * height));
        }
    }

    class square
    {
        public static float AreaSquare(float width)
        {
            return width * width;
        }
    }
}
