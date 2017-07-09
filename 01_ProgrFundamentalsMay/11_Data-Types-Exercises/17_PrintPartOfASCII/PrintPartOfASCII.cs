using System;
class PrintPartOfASCII
{
    static void Main()
    {
        byte from = byte.Parse(Console.ReadLine());
        byte to = byte.Parse(Console.ReadLine());
        char c;
        string charSymbol;
        for (int i = from; i <= to; i++)
        {
            c = (char)i;
            charSymbol = "" + c;
            if (char.IsWhiteSpace(c))
            {
                charSymbol = "white space symbol";

                switch (c)
                {
                    case '\t':
                        charSymbol = "\\t";
                        break;
                    case ' ':
                        charSymbol = "space";
                        break;
                    case '\n':
                        charSymbol = "\\n";
                        break;
                    case '\r':
                        charSymbol = "\\r";
                        break;
                    case '\v':
                        charSymbol = "\\v";
                        break;
                    case '\f':
                        charSymbol = "\\f";
                        break;
                }
            }
            else if ((char.IsControl(c)))
            {
                charSymbol = "conrol symbol";
            }
            Console.Write(charSymbol + " ");
        }
        Console.WriteLine();
    }
}