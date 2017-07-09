using System;

namespace _07_GreaterValue
{
    public class GreaterValue
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(first, second));
                        break;
                    }
                case "char":
                    {
                        char first = char.Parse(Console.ReadLine());
                        char second = char.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(first, second));
                        break;
                    }

                case "string":
                    {
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        Console.WriteLine(GetMax(first, second));
                        break;
                    }
            }
        }

        public static int GetMax(int first, int second)
        {
            if (first >= second) return first;
            return second;
        }
        public static char GetMax(char first, char second)
        {
            if (first >= second) return first;
            return second;
        }
        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0) return first;
            return second;
        }

    }
}