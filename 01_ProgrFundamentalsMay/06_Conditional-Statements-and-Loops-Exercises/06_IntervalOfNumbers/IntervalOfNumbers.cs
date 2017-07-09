using System; 

namespace _06_IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int from = Math.Min(num1, num2);
            int to = Math.Max(num1, num2);

            for (int i = from; i <= to; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
