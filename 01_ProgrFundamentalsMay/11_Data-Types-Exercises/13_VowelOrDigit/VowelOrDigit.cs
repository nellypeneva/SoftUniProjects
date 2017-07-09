using System;
class VowelOrDigit
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());

        if (char.IsDigit(symbol)) 
        {
            Console.WriteLine("digit");
        }
        else if ("aeiouAEIOU".IndexOf(symbol) >= 0)
        {
            Console.WriteLine("vowel");
        }

        else
        {
            Console.WriteLine("other");
        }
    }
}
