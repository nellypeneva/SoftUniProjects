using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(int.Parse)
                                                        .ToList();

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
                    case "exchange":
                    {
                        int startIndex = int.Parse(commands[1]);                       
                        Exchange(startIndex, collection);
                        break;
                    }
                    case "max":
                    {
                        bool isEven = (commands[1] == "even") ? true : false;
                        IndexOfMaxEvenOdd(isEven, collection);
                        break;
                    }
                    case "min":
                    {
                        bool isEven = (commands[1] == "even") ? true : false;
                        IndexOfMinEvenOdd(isEven, collection);
                        break;
                    }
                    case "first":
                    {
                        int count = int.Parse(commands[1]); 
                        bool isEven = (commands[2] == "even") ? true : false;
                        FirstNElements(count, collection, isEven);
                        break;
                    }
                    case "last":
                    {
                        int count = int.Parse(commands[1]);
                        bool isEven = (commands[2] == "even") ? true : false;
                        lastNElements(count, collection, isEven);
                        break;
                    }
                    default:
                        break;
                } 
            }

            Console.WriteLine("[{0}]", String.Join(", ", collection));
        }

        private static void lastNElements(int count, List<int> collection, bool isEven)
        {
            //If the count is greater than the array length, print “Invalid count”
            //If there are not enough elements to satisfy the count, print as many as you can. 
            //If there are zero even/odd elements, print an empty array “[]”
            if (count > collection.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int remainder = (isEven) ? 0 : 1;
            List<int> result = collection.Where(x => x % 2 == remainder).ToList();

            if (result.Count > 0 )
            {
                int start = (result.Count - count < 0) ? 0 : result.Count - count;
                count = (start + count > result.Count) ? result.Count - start : count;
                result = result.GetRange(start, count);
            }
            
            Console.WriteLine("[{0}]", String.Join(", ", result));
        }

        private static void FirstNElements(int count, List<int> collection, bool isEven)
        {
            //returns the first {count} elements -> [1, 8, 2, 3] -> first 2 even -> print [8, 2]
            //If the count is greater than the array length, print “Invalid count”
            //If there are not enough elements to satisfy the count, print as many as you can. 
            //If there are zero even/odd elements, print an empty array “[]”
            if (count > collection.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int remainder = (isEven) ? 0 : 1;
            List<int> result = collection.Where(x => x % 2 == remainder).ToList();

            if (result.Count() > 0)
            {
                count = (count > result.Count()) ? result.Count() : count;
                result = result.GetRange(0, count); 
            }
            
            Console.WriteLine("[{0}]", String.Join(", ", result));
        }

        private static void IndexOfMinEvenOdd(bool isEven, List<int> collection)
        {
            //returns the INDEX of the min even/odd element -> [1, 4, 8, 2, 3] -> min even > print 3
            //If there are two or more equal min/max elements, return the index of the rightmost one
            //If a min/max even/odd element cannot be found, print “No matches”
            int remainder = (isEven) ? 0 : 1;
            var result  = collection.Where(x => x % 2 == remainder);
            if (result.Count() == 0 )
            {
               Console.WriteLine("No matches");
                return;
            }

            int num = result.Min();
            int index = collection.LastIndexOf(num); 
            
            if (index < 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine(index);
        }

        private static void IndexOfMaxEvenOdd(bool isEven, List<int> collection)
        {
            //returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4
            //If there are two or more equal min/max elements, return the index of the rightmost one
            //If a min/max even/odd element cannot be found, print “No matches”
            int remainder = (isEven) ? 0 : 1; 
            var result = collection.Where(x => x % 2 == remainder);

            if (result.Count() == 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            int num = result.Max();

            int index = collection.LastIndexOf(num);

            if (index < 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine(index);
        }

        private static void Exchange(int startIndex, List<int> collection)
        {
            //If the index is outside the boundaries of the array, print “Invalid index”
            if (startIndex < 0 || startIndex >= collection.Count) 
            {
                Console.WriteLine("Invalid index");
                return;
            }

            int shifts = startIndex + 1;
            List<int> range = collection.GetRange(0, shifts);
            collection.RemoveRange(0, shifts);
            collection.AddRange(range);
        }
    }
} 