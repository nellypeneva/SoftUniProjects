using System; 

namespace _01_CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            decimal days = decimal.Parse(Console.ReadLine()); //length of the marathon in days  
            decimal runnersNum = decimal.Parse(Console.ReadLine()); //the number of runners that will participate 
            decimal avgLapsNum = decimal.Parse(Console.ReadLine());//average number of laps every runner makes
            decimal trackLength = decimal.Parse(Console.ReadLine());
            decimal trackCapacity = decimal.Parse(Console.ReadLine()); //runnersNumLimit
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());


            decimal totalRunners = Math.Min(runnersNum, trackCapacity * days);
            decimal totalMeters = totalRunners * avgLapsNum * trackLength;
            decimal totalKm = totalMeters / 1000m;
            decimal moneyRaised = totalKm * moneyPerKm;

            Console.WriteLine("Money raised: {0:f2}", moneyRaised);
        }
    }
}
