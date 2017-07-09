using System; 

namespace _12_TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            long sumBoundary = long.Parse(Console.ReadLine());
            int counter = 0;
            long sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter++;
                    sum += 3 * i * j;
 
                    if(sum >= sumBoundary)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sum, sumBoundary);
                        return; 
                    }
                } 
            }

            Console.WriteLine("{0} combinations", counter);
            Console.WriteLine("Sum: {0}", sum); 
        }
    }
}
