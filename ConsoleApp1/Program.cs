using System;
using Homework02;

namespace ConsoleApp1
{
    class Rectangle
    {
        static float AreaRec(float width, float height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Cal Data of Geometry");
            }

            if (args.Length == 2)
            {
                float rectangle = AreaRec(float.Parse(args[0]), float.Parse(args[1]));
                Console.WriteLine($"Rectangle {args[0]}x{args[1]}: " + rectangle);
                float tri = triangle.AreaTri(float.Parse(args[0]), float.Parse(args[1]));
                Console.WriteLine($"Triangle 0.5x{args[0]}x{args[1]}: " + tri);
                float pri = Prism.AreaPri(float.Parse(args[0]), float.Parse(args[1]));
                Console.WriteLine($"Prism {args[0]}x{args[1]}: " + pri);
                float pyra = pyramid.AreaPyramid(float.Parse(args[0]), float.Parse(args[1]));
                Console.WriteLine($"Pyramid {args[0]}x{args[1]}: " + pyra);
                float dia = Diamond.AreaDiamond(float.Parse(args[0]), float.Parse(args[1]));
                Console.WriteLine($"Diamond 0.3x{args[0]}x{args[1]}: " + dia);
                float squ = square.AreaSquare(float.Parse(args[0]));
                Console.WriteLine($"Square {args[0]}x{args[0]}: " + squ);
            }
        }
    }
    class triangle
    {
        public static float AreaTri(float a, float b)
        {
            return (float)(0.5 * a * b);
        }
    }

    class Prism
    {
        public static float AreaPri(float a, float b)
        {
            return a * b;
        }
    }
}
