using System; 

namespace _03_Megapixels
{
    class Megapixels
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine()); 

            double resolution = (width * height)/ 1000000.0;

            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round(resolution,1));
        }
    }
}
