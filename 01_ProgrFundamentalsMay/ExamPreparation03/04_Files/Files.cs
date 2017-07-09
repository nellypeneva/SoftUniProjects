using System;
using System.Collections.Generic;
using System.Linq; 
namespace _04_Files
{
    class Files
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split('\\');
                string rootDir = parameters[0];
                string[] fileDetails = parameters[parameters.Length - 1].Split(';');
                string fileName = fileDetails[0];
                long size = long.Parse(fileDetails[1]);

                if (!results.ContainsKey(rootDir))
                {
                    results[rootDir] = new Dictionary<string, long>();
                }

                results[rootDir][fileName] = size;
            }

            string[] input = Console.ReadLine().Split(' ');
            string fileExtension = input[0];
            string folder = input[2];

            if (!results.ContainsKey(folder))
            {
                Console.WriteLine("No");
                return;
            }

            var r = results[folder].Where(f => f.Key.EndsWith(fileExtension))
                                      .OrderByDescending(f => f.Value)
                                      .ThenBy(f => f.Key);

            if (r.Count() == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach (var f in r)
            {
                Console.WriteLine("{0} - {1} KB ", f.Key, f.Value);
            }
        }
    }
} 