using System;
using System.Collections.Generic;
using System.Linq; 

namespace _09_JumpAround
{
    class JumpAround
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            int num = numbers[0];
            int sum = num;

            while (true)
            {
                int nextIndex = index + num;
                if (nextIndex >= numbers.Length)
                {
                    nextIndex = index - num;
                    if (nextIndex < 0)
                    {
                        break;
                    }
                }

                num = numbers[nextIndex];
                sum += num;
                index = nextIndex;
            }

            Console.WriteLine(sum);
        }
    }
}
