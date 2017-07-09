using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions; 

namespace _04_Weather
{
    public class Weather
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})(\d{1,}\.\d{0,})([A-Za-z]+)\|";

            List<City> cities = new List<City>();

            Regex regex = new Regex(pattern);


            while (input!="end")
            {
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string city = match.Groups[1].Value;
                    double temp = double.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    int index = cities.FindIndex(item => item.Name == city);

                    if (index>=0)
                    {
                        cities[index].Temp=temp;
                        cities[index].Weather = weather;
                    }
                    else
                    {
                        cities.Add(new City(city, temp, weather));
                    } 
                }

               input = Console.ReadLine(); 
            }

            cities = cities.OrderBy(c => c.Temp).ToList();

            foreach (var c in cities)
            {
                Console.WriteLine("{0} => {1:f2} => {2}", c.Name, c.Temp, c.Weather);  
            }
        }
    }

    // placed here because for this task i can not upload solution 
    class City
    {
        public City(string name, double temp, string weather)
        {
            this.Name = name;
            this.Temp = temp;
            this.Weather = weather;
        }

        public string Name { get; set; }
        public double Temp { get; set; }
        public string Weather { get; set; }
    }
}
 
