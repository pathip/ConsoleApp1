using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02
{
    class pyramid
    {
        public static IEnumerable<float> AreaPyramid(float width, float height)
        {
            yield return (float)(0.3 * width * height);
        }
    }

    class Diamond
    {
        public static IEnumerable<float> AreaDiamond(float width, float height)
        {
            yield return (float)(0.5 * (width * height));
        }
    }

    class square
    {
        public static IEnumerable<float> AreaSquare(float width)
        {
            yield return width * width;
        }
    }
}
