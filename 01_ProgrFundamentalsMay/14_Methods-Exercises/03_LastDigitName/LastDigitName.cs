using System; 

namespace _03_LastDigitName
{
    public class LastDigitName
    {
        public static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(lastDigitName(num));
        }

        public static string lastDigitName(long num)
        {
            string name = "zero";
            int digit = (int)Math.Abs(num % 10);

            switch (digit)
            {
                case 0: name = "zero"; break;
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
            }

            return name;
        }
    }
}
