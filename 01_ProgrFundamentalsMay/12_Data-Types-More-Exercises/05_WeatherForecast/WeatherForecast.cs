using System; 

namespace _05_WeatherForecast
{
    public class WeatherForecast
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            sbyte resultSbyte;
            int resultInt;
            long resultLong;
            double resultDouble;

            if (sbyte.TryParse(input, out resultSbyte ))
            {
                Console.WriteLine("Sunny");
            }
            else if (int.TryParse(input, out resultInt))
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.TryParse(input, out resultLong))
            {
                Console.WriteLine("Windy");
            }
            else if (double.TryParse(input, out resultDouble))
            {
                Console.WriteLine("Rainy");
            }    
        }
    }
}
