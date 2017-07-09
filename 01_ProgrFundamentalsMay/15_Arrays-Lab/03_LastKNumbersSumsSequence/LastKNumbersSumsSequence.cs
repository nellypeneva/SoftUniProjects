using System;

namespace _03_LastKNumbersSumsSequence
{
    public class LastKNumbersSumsSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] result = new long[n];
            result[0] = 1;
            for (int i = 1; i < result.Length; i++)
            {
                int startIndex = ((i - k) >= 0) ? (i - k) : 0;

                for (int j = startIndex; j < i; j++)
                {
                    result[i] += result[j];
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}