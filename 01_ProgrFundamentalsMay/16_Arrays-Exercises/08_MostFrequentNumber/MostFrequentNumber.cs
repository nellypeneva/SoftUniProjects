using System;
using System.Linq;

namespace _08_MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostFrequentNumber = input[0];
            int maxRepeatTimes = 1;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = input[i];
                int counter = 0;

                for (int j = i; j < input.Length; j++)
                {
                    if (currentNumber == input[j])
                    {
                        counter++;
                    }
                }

                if (counter > maxRepeatTimes)
                {
                    maxRepeatTimes = counter;
                    mostFrequentNumber = currentNumber;
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}