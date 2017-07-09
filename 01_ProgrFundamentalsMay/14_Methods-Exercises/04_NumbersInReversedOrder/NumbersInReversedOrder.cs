using System;
using System.Linq;

namespace _04b_NumbersInReversedOrder
{
    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            PrintReverse(input);
        }

        public static void PrintReverse(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
