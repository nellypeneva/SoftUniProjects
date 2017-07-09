using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> collection = Console.ReadLine().Split(new[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries).ToList();
            
            while (true)
            {
                string parameters = Console.ReadLine();

                if (parameters == "end")
                {
                    break;
                }

                string[] commands = parameters.Split();

                switch (commands[0])
                {
                    case "reverse": 
                    {
                        int startIndex = int.Parse(commands[2]);
                        int count = int.Parse(commands[4]);
                        Reverse(startIndex, count, collection);
                        break; 
                    }
                    case "sort": 
                    {
                        int startIndex = int.Parse(commands[2]);
                        int count = int.Parse(commands[4]);
                        Sort(startIndex, count, collection);
                        break; 
                    }
                    case "rollLeft": 
                    {
                        int num = int.Parse(commands[1]);
                        RollLeft(num, collection);
                        break; 
                    }
                    case "rollRight": 
                    {
                        int num = int.Parse(commands[1]);
                        RollRight(num, collection);
                        break; 
                    }
                    default:
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", collection) + "]");
        }


        private static void Sort(int startIndex, int count, List<string> collection)
        {
            if (startIndex < 0 || startIndex >= collection.Count || count < 0 || startIndex + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            } 

            collection.Sort(startIndex, count, StringComparer.InvariantCulture);
        }

        private static void Reverse(int startIndex, int count, List<string> collection)
        {
            if (startIndex < 0 || startIndex >= collection.Count || count < 0 || startIndex + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            collection.Reverse(startIndex, count);
        }

        private static void RollLeft(int shifts, List<string> collection)
        {
            if (shifts < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            shifts = shifts % collection.Count; 
            List<string> range = collection.GetRange(0, shifts);
            collection.RemoveRange(0, shifts);
            collection.AddRange(range);
        } 

        private static void RollRight(int shifts, List<string> collection)
        {
            if (shifts < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            shifts = shifts % collection.Count;

            List<string> range = collection.GetRange(0, collection.Count - shifts);
            collection.RemoveRange(0, collection.Count - shifts);
            collection.AddRange(range);
        } 
    }
}



//private static void rotateLeft(List<int> arr)
//{
//    int firstNum = arr[0];
//    for (int i = 0; i < arr.Count - 1; i++)
//    {
//        arr[i] = arr[i + 1];
//    }
//    arr[arr.Count - 1] = firstNum;
//}
