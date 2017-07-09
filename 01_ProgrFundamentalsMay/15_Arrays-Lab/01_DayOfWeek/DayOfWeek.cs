using System;
using System.Linq;

namespace _01_DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (n > 7 || n < 1)
            {
                Console.WriteLine("Invalid Day!");
                return;
            }

            Console.WriteLine(days[n - 1]);
        }
    }
}
