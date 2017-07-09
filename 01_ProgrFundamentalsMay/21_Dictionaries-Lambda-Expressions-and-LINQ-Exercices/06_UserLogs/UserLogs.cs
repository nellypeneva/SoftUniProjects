using System;
using System.Collections.Generic;
using System.Linq; 

namespace _06_UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] parameters = input.Split(' ');  

                string[] ipInfo = parameters[0].Split('=');
                string[] userInfo = parameters[2].Split('=');

                string username = userInfo[1];
                string ip = ipInfo[1];

                if (!users.ContainsKey(username))
                {
                    users[username] = new Dictionary<string, int>();
                }

                if (!users[username].ContainsKey(ip))
                {
                    users[username][ip] = 0;
                }

                users[username][ip]++;

                input = Console.ReadLine();
            }

            foreach (var item in users)
            {
                Console.WriteLine("{0}:", item.Key);

                var pairs = item.Value.Select(x => String.Format("{0} => {1}", x.Key, x.Value));

                Console.WriteLine("{0}.", String.Join(", ", pairs));
            }
        }
    }
} 