using System; 
namespace _09_RefactorSpecialNumbers
{
    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());     

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sumDigits = 0;
                while (number > 0)
                {
                    sumDigits += number % 10;
                    number = number / 10;
                }

                bool result = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine("{0} -> {1}",i,result);  
            } 
        }
    }
}
