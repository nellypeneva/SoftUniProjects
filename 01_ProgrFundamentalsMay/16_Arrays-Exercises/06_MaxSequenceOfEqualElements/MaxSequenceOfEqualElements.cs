using System;
using System.Linq;

namespace _06_MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startPos = 0;
            int maxLength = 1;
            int currLength = 1;

            for (int i = 1; i < input.Length; i++)
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