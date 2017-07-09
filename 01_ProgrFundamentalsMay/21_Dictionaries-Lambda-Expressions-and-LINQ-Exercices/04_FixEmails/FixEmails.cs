using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int count = 1;
            Dictionary<string, string> resources = new Dictionary<string, string>();
            string key = String.Empty;

            while (input != "stop")
            {
                if (count % 2 == 0)
                {
                    if (input.EndsWith("uk") || input.EndsWith("us"))
                    {
                        resources.Remove(key);
                    }
                    else
                    {
                        resources[key] = input;
                    }
                }
                else
                {
                    key = input;

                    if (!resources.ContainsKey(key))
                    {
                        resources[key] = String.Empty;
                    }
                }

                input = Console.ReadLine();
                count++;
            } 
          
            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}