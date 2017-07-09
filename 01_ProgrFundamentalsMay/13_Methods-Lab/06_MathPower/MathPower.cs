using System;

namespace _06_MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(n, power));
        }

        public static double RaiseToPower(double num, int power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= num; 
            }
            
            return result;
        }
    }
}