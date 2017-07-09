using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            int i = 1;

            while (i < input.Count)
            {
                if (input[i - 1] == input[i])
                {
                    input[i - 1] += input[i];
                    input.RemoveAt(i);
                    i--;

                    if (i < 1)
                    {
                        i = 1;
                    }
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}