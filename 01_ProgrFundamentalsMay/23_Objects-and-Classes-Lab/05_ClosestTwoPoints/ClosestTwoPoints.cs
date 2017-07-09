using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                 double[] pointCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                 
                 points.Add (new Point
                                 {
                                     X = pointCoordinates[0],
                                     Y = pointCoordinates[1]
                                 }
                            );
            }
 
            double minDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    Point firstPoint = points[i];
                    Point secondPoint = points[j];
                    double currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine("{0:f3}", minDistance);
            Console.WriteLine("({0},{1})", firstPointMin.X, firstPointMin.Y);
            Console.WriteLine("({0},{1})", secondPointMin.X, secondPointMin.Y);
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            var result = Math.Sqrt(diffX * diffX + diffY * diffY);
            return result;
        }
    }
}
