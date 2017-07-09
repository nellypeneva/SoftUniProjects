using System;
using System.Globalization;
using System.Linq;

namespace _01_CountWorkingDays
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var holidays = getHolidays(); 
            var counter = 0;

            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DateTime tempDate = new DateTime(2016, i.Month, i.Day); 
                
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday|| holidays.Contains(tempDate))
                {
                    continue;
                }

                counter++;
            }

            Console.WriteLine(counter);
        }

        public static DateTime[] getHolidays()
        {
            var year = 2016;
            var holidays = new DateTime[]{
                new DateTime(year, 01, 01),
                new DateTime(year, 03, 03),

                new DateTime(year, 05, 01),
                new DateTime(year, 05, 06),
                new DateTime(year, 05, 24),

                new DateTime(year, 09, 06),
                new DateTime(year, 09, 22),

                new DateTime(year, 11, 01),
                new DateTime(year, 12, 24),
                new DateTime(year, 12, 25),
                new DateTime(year, 12, 26)
            };

            return holidays;
        }
    }
}