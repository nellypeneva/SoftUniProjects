using System;
using System.Collections.Generic;
using System.Linq;

namespace _01a_RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbersPositive = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    numbersPositive.Add(numbers[i]);
                }
            }

            numbersPositive.Reverse();

            if (numbersPositive.Count > 0)
            {
                Console.WriteLine(String.Join(" ", numbersPositive));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
