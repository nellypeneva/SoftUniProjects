using System; 
namespace _02_CircleArea
{
    public class CircleArea
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}
