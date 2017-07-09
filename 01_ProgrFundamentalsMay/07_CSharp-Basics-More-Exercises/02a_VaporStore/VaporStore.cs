using System; 
namespace _02a_VaporStore
{
    class VaporStore
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            double spent = 0;

            while (true)
            {
                string input = Console.ReadLine(); 

                if (0 == balance)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                if (input == "Game Time")
                {
                    Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", spent, balance);
                    return;
                }

                bool found = true;
                double price=0;

                switch (input)
                {
                    case "OutFall 4": { price = 39.99; break; }
                    case "CS: OG": { price = 15.99; break; }
                    case "Zplinter Zell": { price = 19.99; break; }
                    case "Honored 2": { price = 59.99; break; }
                    case "RoverWatch": { price = 29.99; break; }
                    case "RoverWatch Origins Edition": { price = 39.99; break; }
                    default: { found = false;  break; }
                        
                }

                if (!found)
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (balance - price < 0)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                spent += price;
                balance -= price;
                Console.WriteLine("Bought {0}", input);
            }
        }
    }
}
