using System;
using System.Linq; 

namespace _04_DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var firstPoint = new Point 
            { 
                X = firstPointCoordinates[0],
                Y = firstPointCoordinates[1]
            };

            var secondPointCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var secondPoint = new Point
            {
                X =  secondPointCoordinates[0],  
                Y =  secondPointCoordinates[1] 
            };

            var result = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}", result);
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
