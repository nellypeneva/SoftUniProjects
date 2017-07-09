using System;
using System.Collections.Generic;
using System.Linq; 

namespace _01_OrderByAge
{
    public class OrderByAge
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string line =Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] input = line.Split(' ');
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                persons.Add(new Person(name, id, age));
            }

            persons = persons.OrderBy(x => x.Age).ToList();

            foreach (var person in persons)
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.", person.Name, person.Id, person.Age);
            } 
        }
    }
}
