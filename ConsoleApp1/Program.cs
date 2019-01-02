using System;
using System.Collections.Generic;
using Homework02;

namespace ConsoleApp1
{
    class Geometry
    {
        public static void Main(string[] args)
        {
            float rec , tri, pri;
            IEnumerable<float> pyra, dia, squ;
            try
            {
                rec = Rectangle.AreaRec(float.Parse(args[0]), float.Parse(args[1]));
                tri = triangle.AreaTri(float.Parse(args[0]), float.Parse(args[1]));
                pri = Prism.AreaPri(float.Parse(args[0]), float.Parse(args[1]));
                pyra = pyramid.AreaPyramid(float.Parse(args[0]), float.Parse(args[1]));
                dia = Diamond.AreaDiamond(float.Parse(args[0]), float.Parse(args[1]));
                squ = square.AreaSquare(float.Parse(args[0]));
                foreach (var s in squ)
                {
                    Console.WriteLine($"Square {args[0]}x{args[0]}: " + s);
                }
                Console.WriteLine($"Rectangle {args[0]}x{args[1]}: " + rec);
                Console.WriteLine($"Triangle 0.5x{args[0]}x{args[1]}: " + tri);
                Console.WriteLine($"Prism {args[0]}x{args[1]}: " + pri);
                foreach (var p in pyra)
                {
                    Console.WriteLine($"Pyramid {args[0]}x{args[1]}: " + p);
                }

                foreach (var d in dia)
                {
                    Console.WriteLine($"Diamond 0.3x{args[0]}x{args[1]}: " + d);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Out of Range Exception");
            }
        }
        }
    }

    class Rectangle
    {
        public static float AreaRec(float width, float height) => width * height;
    }
    class triangle
    {
        public static float AreaTri(float width, float height) => (float)(0.5 * width * height);
        
    }

    class Prism
    {
        public static float AreaPri(float width, float height) => width * height;
    }

