using System;
using System.Linq;

namespace _09_ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int middle = numbers.Length / 2;

            if (numbers.Length == 1)
            {
                Console.WriteLine("{0}", numbers[0]);
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine("{0}, {1}", numbers[middle - 1], numbers[middle]);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", numbers[middle - 1], numbers[middle], numbers[middle + 1]);
            }
        }
    }
}