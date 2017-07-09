using System; 

namespace _12_BeerKegs
{
    public class BeerKegs
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegModel = String.Empty;
            double maxVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                var volume = Math.PI * radius * radius * height;

                if (volume > maxVolume) 
                {
                    maxVolume = volume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
