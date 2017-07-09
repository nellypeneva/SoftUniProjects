using System; 

namespace _05_CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new String('|', health), new String('.', maxHealth - health));
            Console.WriteLine("Energy: |{0}{1}|", new String('|', energy), new String('.', maxEnergy - energy)); 
        }
    }
}
