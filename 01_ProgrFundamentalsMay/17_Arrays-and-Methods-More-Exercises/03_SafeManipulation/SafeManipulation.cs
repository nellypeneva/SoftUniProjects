using System;
using System.Collections.Generic;
using System.Linq; 

namespace _03_SafeManipulation
{
    public class SafeManipulation
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');         
            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (command == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (command.Contains("Replace"))
                {
                    string[] parameters = command.Split(' ');
                    int index = int.Parse(parameters[1]);

                    if (index>=0 && index < input.Length)
                    {
                        input[index] = parameters[2];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    } 
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", input));
        }
    }
}
