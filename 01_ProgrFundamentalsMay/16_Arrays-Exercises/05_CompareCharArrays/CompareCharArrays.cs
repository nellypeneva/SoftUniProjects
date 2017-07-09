using System;
using System.Linq;

namespace _05_CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] input1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] input2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (input1.Length < input2.Length)
            {
                Console.WriteLine("{0}{1}{2}", String.Join("", input1), Environment.NewLine, String.Join("", input2));
            }
            else if (input2.Length < input1.Length)
            {
                Console.WriteLine("{0}{1}{2}", String.Join("", input2), Environment.NewLine, String.Join("", input1));
            }
            else  
            {

                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] < input2[i])
                    {
                        Console.WriteLine("{0}{1}{2}", String.Join("", input1), Environment.NewLine, String.Join("", input2));
                        return;
                    }

                    if (input2[i] < input1[i])
                    {
                        Console.WriteLine("{0}{1}{2}", String.Join("", input2), Environment.NewLine, String.Join("", input1));
                        return;
                    }
                }

                Console.WriteLine("{0}{1}{2}", String.Join("", input1), Environment.NewLine, String.Join("", input2));
            }
        }
    }
}