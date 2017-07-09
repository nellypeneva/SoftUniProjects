using System; 

namespace _06_CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(a, ha));
        }

        public static double TriangleArea(double a, double ha)
        {
            return (a * ha) / 2.0;
        }
    }
}
