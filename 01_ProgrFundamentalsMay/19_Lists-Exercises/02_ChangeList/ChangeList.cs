using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_ChangeList
{
    public class ChangeList
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string line = Console.ReadLine();

            while (line != "Odd" && line != "Even")
            {
                string[] cmd = line.Split(' ');

                switch (cmd[0])
                {
                    case "Delete": 
                    {
                        int item = int.Parse(cmd[1]);
                        input.RemoveAll(x=> x == item);
                        break; 
                    }
                    case "Insert":
                    {
                        int item = int.Parse(cmd[1]); 
                        int position = int.Parse(cmd[2]);
                        input.Insert(position, item);
                        break;
                    } 

                    default:
                        break;
                } 

                line = Console.ReadLine();
            }

            if (line == "Odd")
            {
                input = input.Where(x => x % 2 != 0).ToList();
            }
            else if (line == "Even")
            {
                input = input.Where(x => x % 2 == 0).ToList();
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
