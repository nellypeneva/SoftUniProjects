using System;
using System.Linq;

namespace _03_IntersectionOfCircles
{
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            Circle circle1 = GetCircle();
            Circle circle2 = GetCircle();
            string result = (Intersect(circle1, circle2)) ? "Yes" : "No";
            Console.WriteLine(result);
        }

        public static Circle GetCircle()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point point = new Point() { X = input[0], Y = input[1] };
            Circle circle = new Circle() { Point = point, Radius = input[2] };
            return circle;
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double diffX = firstPoint.X - secondPoint.X;
            double diffY = firstPoint.Y - secondPoint.Y;
            double result = Math.Sqrt(diffX * diffX + diffY * diffY);
            return result;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            double distance = CalculateDistance(c1.Point, c2.Point);

            if (distance <= c1.Radius + c2.Radius)
            {
                return true;
            }

            return false;
        } 
    }
}
