using System;
using System.Collections.Generic;
using System.Linq; 

namespace _07_BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int num = parameters[0];
            int power = parameters[1];

            int index = input.IndexOf(num);

            while (index > -1)
            {
                int startPos = index - power;
                int count = 2 * power + 1;

                if (startPos < 0)
                {
                    count = count + startPos;
                    startPos = 0;
                }

                if (startPos + count > input.Count)
                {
                    count = input.Count - startPos;
                }

                input.RemoveRange(startPos, count);

                index = input.IndexOf(num);
            }

            Console.WriteLine(input.Sum());
        }
    }
}
