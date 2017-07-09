using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> numbersSquare = new List<int>();

            foreach (var item in numbers)
            {
                if (Math.Sqrt(item) % 1 == 0)
                {
                    numbersSquare.Add(item);
                }
            }

            numbersSquare.Sort();
            numbersSquare.Reverse();
            Console.WriteLine(String.Join(" ", numbersSquare));
        }
    }
}