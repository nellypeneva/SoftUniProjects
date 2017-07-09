using System;
using System.Collections.Generic; 

namespace _05_ParkingValidation
{
    public class ParkingValidation
    {
        public static void Main()
        {
            int n =  int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');
                string command = parameters[0];
                string user = parameters[1];                

                if (command == "register")
                {
                    string licence = parameters[2]; 

                    if (users.ContainsKey(user))
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", users[user]);
                        continue;
                    }

                    if (!IsValid(licence))
                    {
                        Console.WriteLine("ERROR: invalid license plate {0}", licence);
                        continue;
                    } 

                    if (users.ContainsValue(licence))
                    {
                        Console.WriteLine("ERROR: license plate {0} is busy", licence);
                        continue;
                    }

                    users[user] = licence;
                    Console.WriteLine("{0} registered {1} successfully", user, licence);
                }
                else if (command == "unregister")
                {
                    if (!users.ContainsKey(user))
                    {
                        Console.WriteLine("ERROR: user {0} not found", user);
                        continue;
                    }

                    bool result= users.Remove(user);

                    if (result)
                    {
                        Console.WriteLine("user {0} unregistered successfully", user);
                    }
                }
            }

            foreach (var item in users)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value); 
            }
        }

        public static bool IsValid(string key)
        {
            bool valid = (key.Length != 8) ? false : true;

            if (valid)
            {
                if (!isLatinUpper(key[0]) || !isLatinUpper(key[1]) || !isLatinUpper(key[6]) || !isLatinUpper(key[7]))
                {
                    valid = false;
                }

                if (!char.IsDigit(key[2]) || !char.IsDigit(key[3]) || !char.IsDigit(key[4]) || !char.IsDigit(key[5]))
                {
                    valid = false;
                }
            }


            
            return valid;
        }

        public static bool isLatinUpper(char letter)
        {
            if (letter >= 'A' && letter <= 'Z')
            {
                return true;
            }

            return false;
        }
    }
} 