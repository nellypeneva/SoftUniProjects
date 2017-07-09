using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; 

namespace _02_VehicleCatalogue
{
    public class VehicleCatalogue
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] input = line.Split(' ');
                string type = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input[0].ToLower()); ;
                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);

                vehicles.Add(new Vehicle(model, type, color, horsepower));
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Close the Catalogue")
                {
                    break;
                }
                 
                int index = vehicles.FindIndex(x => x.Model == line) ;

                if (index >=0)
                {
                   Vehicle vehicle = vehicles[index];
                   Console.WriteLine(String.Format("Type: {0}", vehicle.Type));
                   Console.WriteLine(String.Format("Model: {0}", vehicle.Model));
                   Console.WriteLine(String.Format("Color: {0}", vehicle.Color));
                   Console.WriteLine(String.Format("Horsepower: {0}", vehicle.Horsepower)); 
                } 
            }

            var cars = vehicles.Where(x => x.Type == "Car");
            var trucks = vehicles.Where(x => x.Type == "Truck");
            double carHorsePower = (cars.Count() > 0) ? cars.Select(x => x.Horsepower).Average(): 0;
            double truckHorsePower = (trucks.Count() > 0) ? trucks.Select(x => x.Horsepower).Average(): 0;

            Console.WriteLine("Cars have average horsepower of: {0:f2}.", carHorsePower);
            Console.WriteLine("Trucks have average horsepower of: {0:f2}.", truckHorsePower);
        }
    }
} 