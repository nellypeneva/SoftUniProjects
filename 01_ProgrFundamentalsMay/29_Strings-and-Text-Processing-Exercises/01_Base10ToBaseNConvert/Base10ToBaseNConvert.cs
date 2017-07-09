using System;
using System.Numerics;
using System.Text;

namespace _01_Base10ToBaseNConvert
{
    public class Base10ToBaseNConvert
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int toBase = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
           
            StringBuilder result = new StringBuilder();

            while (number > 0)
            {
                BigInteger remainder = number % toBase;
                result.Insert(0, remainder.ToString());
                number /= toBase;
            }

            Console.WriteLine(result);
        }
    }
}
