using System;

namespace _15_NeighbourWars
{
    class NeighbourWars
    {
        static void Main()
        {
            int damageOdd = int.Parse(Console.ReadLine()); // Pesho’s damage, Pesho attacks with “Roundhouse kick” on every odd turn. 
            int damageEven = int.Parse(Console.ReadLine()); // Gosho’s damage, Gosho attacks with “Thunderous fist” on every even turn 

            int healthPesho = 100;
            int healthGosho = 100;

            int round = 0;

            while (true) 
            {
                round++; 
                bool isEven = round % 2 == 0;

                if (isEven)  
                {
                    healthPesho -= damageEven;
                }
                else  
                {
                    healthGosho-=damageOdd;
                }

                if(healthPesho <= 0 || healthGosho<=0)
                { 
                    string winnerName = (healthPesho <= 0) ? "Gosho" : "Pesho";
                    Console.WriteLine("{0} won in {1}th round.", winnerName, round); 
                    break;
                }
                 
                if(isEven)
                {
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
                }
                else
                {
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthGosho);
                }

                if (round % 3 == 0)  
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
        
        }
    }
}
