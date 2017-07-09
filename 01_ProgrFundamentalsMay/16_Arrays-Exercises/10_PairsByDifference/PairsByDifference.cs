using System;
using System.Linq;

namespace _10_PairsByDifference
{
    public class PairsByDifference
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int numPairs = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = input[i];

                for (int j = i; j < input.Length; j++)
                {
                    if (Math.Abs(currentNumber - input[j]) == diff)
                    {
                        numPairs++;
                    }
                }
            }

            Console.WriteLine(numPairs);
        }
    }
}