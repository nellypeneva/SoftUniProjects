using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> games = new Dictionary<string, double>()
                        {
                            {"OutFall 4", 39.99},
                            {"CS: OG", 15.99},
                            {"Zplinter Zell", 19.99},
                            {"Honored 2", 59.99},
                            {"RoverWatch", 29.99},
                            {"RoverWatch Origins Edition", 39.99} 
                        };

            double balance = double.Parse(Console.ReadLine());
            double spent = 0;


            while(true)
            {
                string input = Console.ReadLine();

                if (0 == balance)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                
                if (input == "Game Time")
                { 
                    Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", spent, balance);
                    return;
                } 

                if(!games.ContainsKey(input))
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                double price = games[input];

                if(balance - price < 0)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                spent += price;
                balance -= price;
                Console.WriteLine("Bought {0}", input);
            }
        }
    }
}