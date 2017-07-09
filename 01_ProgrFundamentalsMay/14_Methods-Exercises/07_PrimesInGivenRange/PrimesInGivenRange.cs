using System;
using System.Collections.Generic;

namespace _07_PrimesInGivenRange
{
    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> list = FindPrimesInRange(startNum, endNum);

            string result = string.Join(", ", list.ToArray());
            Console.WriteLine(result);
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }

            return list;
        }

        public static bool IsPrime(long number)
        {
            bool prime = false;
            var boundary = (int)Math.Ceiling(Math.Sqrt(number));

            if (number > 1)
            {
                prime = true;

                if (number == 2) return true;

                for (int i = 2; i <= boundary; i++)
                {
                    if (0 == number % i)
                    {
                        prime = false;
                        break;
                    }
                }
            }

            return prime;
        }

    }
}