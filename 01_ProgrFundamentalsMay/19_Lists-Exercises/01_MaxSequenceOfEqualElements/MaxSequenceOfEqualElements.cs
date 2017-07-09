using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int startPos = 0;
            int maxLength = 1;
            int currLength = 1;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i - 1] == input[i])
                {
                    currLength++;

                    if (currLength > maxLength)
                    {
                        startPos = i - (currLength - 1);
                        maxLength = currLength;
                    }
                }
                else
                {
                    currLength = 1;
                }
            }

            for (int i = startPos; i < startPos + maxLength; i++)
            {
                Console.Write("{0} ", input[i]);
            }

            Console.WriteLine();
        }
    }
}