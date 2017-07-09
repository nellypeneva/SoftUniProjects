using System;
using System.Linq;

namespace _04_SieveOfEratosthenes
{
    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write("{0} ", i);

                    for (int j = 2; (j * i) < primes.Length; j++)
                    {

                        primes[j * i] = false;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}