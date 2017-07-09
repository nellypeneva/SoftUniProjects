using System; 

namespace _06_DNASequences
{
    class DNASequences
    {
        static void Main()
        {
            int checkSum = int.Parse(Console.ReadLine());
            char[] nucleotides = { 'A', 'C', 'G', 'T' };
            int[] numeriValues = { 1, 2, 3, 4 };

            int counter = 0;

            for (int first = 0; first < nucleotides.Length; first++)
            {
                for (int second = 0; second < nucleotides.Length; second++)
                {
                    for (int third = 0; third < nucleotides.Length; third++)
                    {
                        counter++;

                        char symbol='X';
                        int sum = numeriValues[first] + numeriValues[second] + numeriValues[third];

                        if (sum >=checkSum)
                        {
                            symbol = 'O';  
                        }

                        Console.Write("{0}{1}{2}{3}{4} ", symbol, nucleotides[first], nucleotides[second], nucleotides[third], symbol);

                        if (counter == 4)
                        {
                            Console.WriteLine();
                            counter = 0;
                        }
                    }
                }
            }
        }
    }
}
 