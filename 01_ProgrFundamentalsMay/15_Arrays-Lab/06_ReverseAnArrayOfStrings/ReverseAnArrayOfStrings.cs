using System;
using System.Linq;

namespace _06_ReverseAnArrayOfStrings
{
    public class ReverseAnArrayOfStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine(string.Join(" ", input.Reverse()));

            //for (int i = 0; i < input.Length / 2; i++)
            //{ 
            //    string temp = input[i];
            //    int reversedIndex = input.Length - i - 1;
            //    input[i] = input[reversedIndex];
            //    input[reversedIndex] = temp;
            //}

            //Console.WriteLine(string.Join(" ", input));
        }
    }
}