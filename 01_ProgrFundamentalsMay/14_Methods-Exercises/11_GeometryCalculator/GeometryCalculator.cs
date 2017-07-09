using System;

namespace _11_GeometryCalculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            string parameter = Console.ReadLine();
            switch (parameter.ToLower())
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f2}", TriangleArea(side, height));
                        break;
                    }
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f2}", SquareArea(side));
                        break;
                    }
                case "rectangle":
                    {
                        double width = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f2}", RectangleArea(width, height));
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f2}", CircleArea(radius));
                        break;
                    }
            }
        }

        public static double TriangleArea(double side, double height)
        {
            return (side * height) / 2.0;
        }
        public static double RectangleArea(double width, double height)
        {
            return width * height;
        }
        public static double SquareArea(double side)
        {
            return side * side;
        }
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}