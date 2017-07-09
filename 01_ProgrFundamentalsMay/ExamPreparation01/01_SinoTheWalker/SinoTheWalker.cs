using System; 
using System.Globalization;
using System.Numerics;

namespace _01_SinoTheWalker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);
            BigInteger numSteps = int.Parse(Console.ReadLine());
            int numSeconds = int.Parse(Console.ReadLine());
            BigInteger secondTotal =  numSteps *  numSeconds;
            BigInteger totalTimeInSeconds = time.Hours * 3600 + time.Minutes * 60 + time.Seconds + secondTotal;

            BigInteger arrivalHour = (totalTimeInSeconds / 3600) % 24;
            BigInteger arrivalMinutes = (totalTimeInSeconds / 60) % 60;
            BigInteger arrivalSeconds = totalTimeInSeconds % 60;

            Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", arrivalHour, arrivalMinutes, arrivalSeconds);
        }
    }
}
