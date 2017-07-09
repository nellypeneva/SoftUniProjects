using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; 

namespace _10a_StudentGroups
{
    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> towns = new List<Town>();
            List<Group> groups = new List<Group>();

            ReadTownAndStudends(towns); 

            towns = towns.OrderBy(x => x.Name).ToList();            
            groups = GetGroups(towns).OrderBy(x => x.Town.Name).ToList();
            int townsCount = groups.Select(x => x.Town).Distinct().Count();

            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, townsCount);

            foreach (var group in groups)
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, String.Join(", ", group.Students.Select(x=>x.Email))); 
            }
        }

        public static List<Group> GetGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (var town in towns)
            {
                List<Student> students = town.Students.OrderBy(x => x.RegDate).ThenBy(x => x.Name).ThenBy(x => x.Email).ToList(); 

                while (students.Any())
                {
                    Group group = new Group(town);
                    group.Students = students.Take(group.Town.NumSeats).ToList();
                    students = students.Skip(group.Town.NumSeats).ToList();
                    groups.Add(group);
                }
            } 

            return groups;
        }
        
        public static void ReadTownAndStudends(List<Town> towns)
        {
            while (true)
            {
                string input = Console.ReadLine(); 
            
                if (input == "End")
                {
                    break;
                }

                if (input.Contains("=>"))
                {
                    string[] parameters = input.Split("=>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                               .Select(x => x.Trim())
                                               .ToArray();

                    string city = parameters[0];

                    string[] cityInfo = parameters[1].Split(' ');
                    int numSeats = int.Parse(cityInfo[0]);
                    towns.Add(new Town(city, numSeats));

                    continue;
                }

                string[] line = input.Split('|')
                                     .Select(x => x.Trim())
                                     .ToArray(); 
                
                string name = line[0];
                string email = line[1];
                DateTime date = DateTime.ParseExact(line[2], "d-MMM-yyyy", CultureInfo.InvariantCulture); 

                towns.LastOrDefault().Students.Add(new Student(name, email, date)); 
            }
        }
    }
}
