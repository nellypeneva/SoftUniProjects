using System;

namespace _04_DrawFilledSquare
{
    public class DrawFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            printHeader(n);
            printMiddle(n);
            printHeader(n);
        }

        public static void printHeader(int n)
        {
            Console.WriteLine(new String('-', 2 * n));
        }

        public static void printMiddle(int n)
        {
            for (int j = 1; j <= n - 2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}