using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();

            if (numbers.Count > 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}