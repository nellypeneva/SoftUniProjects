using System;
class PracticeCharactersAndStrings
{
    static void Main()
    {
        string firstString = Console.ReadLine();
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char thirdChar = char.Parse(Console.ReadLine());
        string secondString = Console.ReadLine();
        Console.WriteLine(firstString + Environment.NewLine + firstChar + Environment.NewLine +
                            secondChar + Environment.NewLine + thirdChar + Environment.NewLine + secondString);
    }
} 
