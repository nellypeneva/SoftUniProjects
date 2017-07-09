using System;
using System.Collections.Generic;
using System.Linq; 
namespace _04_PopulationAggregation
{
    public class PopulationAggregation
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string prohibitedSymbols = "@#$&0123456789" ;
            SortedDictionary<string, int> citiesNumByCountry = new SortedDictionary<string, int>();
            Dictionary<string, long> populationByCity = new Dictionary<string, long>();
            while (input != "stop")
            {
                  string[] parameters= input.Split('\\'); 
                  string city;
                  string country;

                  if (char.IsUpper(parameters[0][0]))
                  {
                      country = parameters[0];
                      city = parameters[1];
                  }
                  else
                  {
                      country = parameters[1];
                      city = parameters[0];
                  }

                  country = removeProhibitedChars(country, prohibitedSymbols);
                  city = removeProhibitedChars(city, prohibitedSymbols);
                  long population = long.Parse(parameters[2]);

                  //Count all towns in each country. In case of repeating towns for certain country, count the duplicated towns.
                  if (!citiesNumByCountry.ContainsKey(country))
                  {
                      citiesNumByCountry[country]=0;
                  }

                  citiesNumByCountry[country]++;

                  //In case of repeating towns, count the last seen population for each town (ignore the others).
                  populationByCity[city] = population;

                  input = Console.ReadLine();
            }

            foreach (var c in citiesNumByCountry)
            {
                Console.WriteLine("{0} -> {1}",c.Key, c.Value);
            }

            var result = populationByCity.OrderByDescending(x => x.Value).Take(3);

            foreach (var item in result)
            {
                 Console.WriteLine("{0} -> {1}",item.Key, item.Value);
            }
        }

        private static string removeProhibitedChars(string text,string prohibitedSymbols)
        {
            foreach (var ch in prohibitedSymbols)
            {
                text = text.Replace(ch.ToString(),"");
            }

            return text;
        }
    }
}
