using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (numbers.Count > 0)
            {
                numbers.Sort();
                int previous = numbers[0];
                int count = 1;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (previous == numbers[i])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", previous, count);
                        count = 1;
                    }

                    previous = numbers[i];
                }

                Console.WriteLine("{0} -> {1}", previous, count);
            }

        }
    }
}