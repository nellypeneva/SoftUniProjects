using System;

namespace _08_CenterPoint
{
    public class CenterPoint
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestPoint(x1, y1, x2, y2);
        }


        public static double DistanceToCenter(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }

        public static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (DistanceToCenter(x1, y1) < DistanceToCenter(x2, y2))
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}
