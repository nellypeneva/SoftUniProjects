using System; 

namespace _03_WaterOverflow
{
    public class WaterOverflow
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int litresWaterTotal = 0;

            for (int i = 0; i < n; i++)
            {
                int litresWater = int.Parse(Console.ReadLine());
                if (litresWaterTotal + litresWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");    
                }
                else
                {
                    litresWaterTotal += litresWater;
                } 
            }

            Console.WriteLine(litresWaterTotal);
        }
    }
}