using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04a_FixEmails
{
    class FixEmails
    {
        static void Main()
        {

            string input = Console.ReadLine(); 
            Dictionary<string, string> resources = new Dictionary<string, string>();

            while (input != "stop")
            {
                string email = Console.ReadLine();

                if (!email.EndsWith("uk") && !email.EndsWith("us"))
                {
                    resources[input] = email;
                }

                input = Console.ReadLine(); 
            }

            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
