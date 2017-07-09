using System; 

namespace _04_Hotel
{
    class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalStudio = -1.0;
            double totalDouble = -1.0;
            double totalSuite = -1.0;

            if (month == "May" || month == "October")
            {
                if (month == "October" && nights > 7)
                {
                    totalStudio = (nights - 1) * 50;
                } 
                else
                {
                    totalStudio = nights * 50; 
                }  

                totalDouble = nights * 65;
                totalSuite = nights * 75;

                if (nights > 7)
                {
                    totalStudio = totalStudio * 0.95;
                }

            }
            else if (month == "June" || month == "September")
            {

                if (month == "September" && nights > 7)
                {
                    totalStudio = (nights - 1) * 60;
                }                    
                else
                {
                    totalStudio = nights * 60; 
                }  

                totalDouble = nights * 72;
                totalSuite = nights * 82;

                if (nights > 14)
                {
                    totalDouble = totalDouble * 0.9;
                }
                 
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                totalStudio = nights * 68;
                totalDouble = nights * 77;
                totalSuite = nights * 89;

                if (nights > 14)
                {
                    totalSuite = totalSuite * 0.85;
                }
            }

            if (totalDouble != 1 && totalStudio != -1 && totalSuite != -1)
            {
                Console.WriteLine("Studio: {0:f2} lv.", totalStudio); 
                Console.WriteLine("Double: {0:f2} lv.", totalDouble); 
                Console.WriteLine("Suite: {0:f2} lv.", totalSuite);
            }
        }
    }
}
