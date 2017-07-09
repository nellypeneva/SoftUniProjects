using System;
using System.Linq;

namespace _04_TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] intArray = input.Split(' ').Select(int.Parse).ToArray();
            bool found = false;

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    var sum = intArray[i] + intArray[j];

                    if (intArray.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", intArray[i], intArray[j], sum);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}