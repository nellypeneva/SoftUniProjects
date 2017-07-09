using System; 

namespace _03_MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", miles * 1.60934);
        }
    }
}
