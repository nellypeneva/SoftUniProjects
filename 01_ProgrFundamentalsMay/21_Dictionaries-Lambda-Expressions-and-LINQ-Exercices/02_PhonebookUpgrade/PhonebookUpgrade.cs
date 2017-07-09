using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_PhonebookUpgrade
{
    public class PhonebookUpgrade
    {
        public static void Main()
        { 
            string input = Console.ReadLine();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                string[] parameters = input.Split(' ');  

                switch (parameters[0])
                {
                    case "A":
                    {
                        string name = parameters[1];
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
                        string name = parameters[1];
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

                    case "ListAll":
                    {
                        foreach (var item in phonebook)
                        {
                            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                        }
                        break;
                    } 
                }

                input = Console.ReadLine();
            } 
        }
    }
}
