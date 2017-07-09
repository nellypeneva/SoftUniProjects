using System; 
class FastPrimeChecker
{
    static void Main()
    { 
        int n = int.Parse(Console.ReadLine());
        for (int digit = 2; digit <= n; digit++)
        {    
            bool isPrime = true;
            for (int divider = 2; divider <= Math.Sqrt(digit); divider++)
            {
                if (digit % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("{0} -> {1}", digit, isPrime);
        } 
    }
}
