using System;
using System.Collections.Generic;
using System.Linq; 

namespace _01_Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input!="END")
            {
                string[] parameters = input.Split(' '); 
                string name = parameters[1];

                switch (parameters[0])
                {
                    case "A":
                    {
                        string phoneNumber = parameters[2];

                        if (!phonebook.ContainsKey(name))
                        {
                            phonebook[name] = String.Empty;
                        }

                        phonebook[name] = phoneNumber;
                        break; 
                    } 

                    case "S":
                    {
                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", name);
                        }

                        break;
                    } 
                }
                                
                input = Console.ReadLine();
            } 
        }
    }
}
