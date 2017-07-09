using System; 

namespace _11_FiveDifferentNumbers
{
    class FiveDifferentNumbers
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (Math.Abs( num1 - num2 ) < 5 )
            {
                Console.WriteLine("No");
                return;
            }


            for (int firstDigit = num1; firstDigit <= num2; firstDigit++)
            {
                for (int secondDigit = firstDigit+1; secondDigit <= num2; secondDigit++)
                {
                    for (int thirdDigit = secondDigit+1; thirdDigit <= num2; thirdDigit++)
                    {
                        for (int forthDigit = thirdDigit+1; forthDigit <= num2; forthDigit++)
                        {
                            for (int fifthDigit = forthDigit+1; fifthDigit <= num2; fifthDigit++)
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4}", firstDigit, secondDigit, thirdDigit, forthDigit, fifthDigit); 
                            }
                        }
                    }
                }
            }
            
        }
    }
}
