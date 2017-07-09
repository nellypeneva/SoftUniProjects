using System; 

namespace _00_17.Altitude
{
    class Altitude
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            double initialAltitude = double.Parse(input[0]);

            for (int i = 1; i < input.Length-1; i+=2)
            {
                string direction = input[i];
                double meters = double.Parse(input[i + 1]);

                switch (direction)
                {
                    case "up":
                    {
                        initialAltitude += meters;
                        break;
                    }
                    case "down":
                    {
                        initialAltitude -= meters;
                        break;
                    }

                    default:
                        break;
                }

                if (initialAltitude<=0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine("got through safely. current altitude: {0}m", initialAltitude);
        }
    }
}
