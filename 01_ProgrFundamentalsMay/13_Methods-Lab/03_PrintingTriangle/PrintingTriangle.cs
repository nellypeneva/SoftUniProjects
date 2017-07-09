using System;

namespace _03_PrintingTriangle
{
    public class PrintingTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            printTriangle(n);
        }

        public static void printTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                printTriangleRow(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                printTriangleRow(i);
            }
        }
        public static void printTriangleRow(int num)
        {
            for (int j = 1; j <= num; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
