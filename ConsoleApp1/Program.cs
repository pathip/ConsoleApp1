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
            
            if (args.Length == 2)
            {
                float rectangle, tri, pri, pyra, dia, squ;
                rectangle = AreaRec(float.Parse(args[0]), float.Parse(args[1]));
                tri = triangle.AreaTri(float.Parse(args[0]), float.Parse(args[1]));
                pri = Prism.AreaPri(float.Parse(args[0]), float.Parse(args[1]));
                pyra = pyramid.AreaPyramid(float.Parse(args[0]), float.Parse(args[1]));
                dia = Diamond.AreaDiamond(float.Parse(args[0]), float.Parse(args[1]));
                squ = square.AreaSquare(float.Parse(args[0]));
                Console.WriteLine($"Square {args[0]}x{args[0]}: " + squ);
                Console.WriteLine($"Rectangle {args[0]}x{args[1]}: " + rectangle);
                Console.WriteLine($"Triangle 0.5x{args[0]}x{args[1]}: " + tri);
                Console.WriteLine($"Prism {args[0]}x{args[1]}: " + pri);
                Console.WriteLine($"Pyramid {args[0]}x{args[1]}: " + pyra);
                Console.WriteLine($"Diamond 0.3x{args[0]}x{args[1]}: " + dia);
            }
            else
            {
                Console.WriteLine("Cal Data of Geometry");
            }
        }
    }
    class triangle
    {
        public static float AreaTri(float width, float height)
        {
            return (float)(0.5 * width * height);
        }
    }

    class Prism
    {
        public static float AreaPri(float width, float height)
        {
            return width * height;
        }
    }
}
