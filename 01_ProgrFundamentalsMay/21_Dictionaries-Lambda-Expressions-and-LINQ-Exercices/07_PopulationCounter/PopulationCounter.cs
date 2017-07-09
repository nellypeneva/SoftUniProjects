using System;
using System.Collections.Generic;
using System.Linq; 

namespace _07_PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> statistics = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] parameters = input.Split('|');
                string city = parameters[0];
                string country= parameters[1];
                long cityPopulation = long.Parse(parameters[2]);

                if (!statistics.ContainsKey(country))
                {
                    statistics[country] = new Dictionary<string, long>();
                }

                if (!statistics[country].ContainsKey(city))
                {
                    statistics[country][city] = 0;
                }

                statistics[country][city] += cityPopulation;

                input = Console.ReadLine();
            } 

            var countries = statistics.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var country in countries)
            {
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value.Values.Sum());

                var cities=country.Value.OrderByDescending(x => x.Value);

                foreach (var city in cities)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
             
        }
    }
}
