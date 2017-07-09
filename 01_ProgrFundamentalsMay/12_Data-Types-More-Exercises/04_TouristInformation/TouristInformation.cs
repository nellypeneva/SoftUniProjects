using System; 

namespace _04_TouristInformation
{
    publicclass TouristInformation
    {
        public static void Main()
        {
            string imperialUnitType = Console.ReadLine();
            double imperialUnitValue = double.Parse(Console.ReadLine()); 

            switch (imperialUnitType)
            {
                case "miles": 
                    {
                        double result = imperialUnitValue * 1.6;
                        Console.WriteLine("{0} miles = {1:f2} kilometers", imperialUnitValue, result);
                        break;
                    }
                case "inches":
                    {
                        double result = imperialUnitValue * 2.54;
                        Console.WriteLine("{0} inches = {1:f2} centimeters", imperialUnitValue, result);
                        break;
                    }
                case "feet":
                    {
                        double result = imperialUnitValue * 30;
                        Console.WriteLine("{0} feet = {1:f2} centimeters", imperialUnitValue, result);
                        break;
                    }
                case "yards":
                    {
                        double result = imperialUnitValue * 0.91;
                        Console.WriteLine("{0} yards = {1:f2} meters", imperialUnitValue, result);
                        break;
                    }
                case "gallons":
                    {
                        double result = imperialUnitValue * 3.8;
                        Console.WriteLine("{0} gallons = {1:f2} liters", imperialUnitValue, result);
                        break;
                    }
                default:
                    break;
            } 
        }
    }
}
