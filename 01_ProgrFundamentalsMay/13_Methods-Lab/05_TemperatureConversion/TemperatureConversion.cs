using System; 

namespace _05_TemperatureConversion
{
    public class TemperatureConversion
    {
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:f2}", celsius);

        }

        public static double FahrenheitToCelsius(double fh)
        {
            return (fh - 32) * 5 / 9;
        }
    }
}
