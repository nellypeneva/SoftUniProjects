using System;
using System.Linq;

namespace _05_RoundingNumbers
{
    public class RoundingNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            double[] arr = input.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} => {1}", arr[i], Math.Round(arr[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}