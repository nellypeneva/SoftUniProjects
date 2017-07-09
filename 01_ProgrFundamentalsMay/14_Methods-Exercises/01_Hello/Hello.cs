using System;

namespace _01_Hello
{
    public class Hello
    {
        public static void Main()
        {
            Greeting(Console.ReadLine());
        }

        public static void Greeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}