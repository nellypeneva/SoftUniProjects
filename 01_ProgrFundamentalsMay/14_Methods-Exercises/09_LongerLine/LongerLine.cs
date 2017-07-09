using System;

namespace _09_LongerLine
{
    public class LongerLine
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (LineLength(x1, y1, x2, y2) >= LineLength(x3, y3, x4, y4))
            {
                printPointsByDistance(x1, y1, x2, y2);
            }
            else
            {
                printPointsByDistance(x3, y3, x4, y4);
            }
        }


        public static double LineLength(double x1, double y1, double x2, double y2)
        {
            double lengthX = Math.Abs(x1 - x2);
            double lengthY = Math.Abs(y1 - y2);
            double lineLength = Math.Sqrt(lengthX * lengthX + lengthY * lengthY);
            return lineLength;
        }

        public static double DistanceToCenter(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }

        public static void printPointsByDistance(double x1, double y1, double x2, double y2)
        {
            if (DistanceToCenter(x1, y1) <= DistanceToCenter(x2, y2))
            {
                Console.Write("({0}, {1})", x1, y1);
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.Write("({0}, {1})", x2, y2);
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }

    }
}