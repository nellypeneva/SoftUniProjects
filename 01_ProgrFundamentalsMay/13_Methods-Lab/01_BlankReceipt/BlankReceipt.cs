using System;
namespace _01_BlankReceipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }
        private static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00a9 SoftUni");
        }
    }
}
