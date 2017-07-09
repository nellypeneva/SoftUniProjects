using System;
using System.Collections.Generic;
using System.Linq; 

namespace _03_ImmuneSystem
{
    public class ImmuneSystem
    {
        public static void Main()
        {
            int initialHealth = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<string> viruses = new List<string>();            
            int health = initialHealth;
 
            while (input != "end")
            {
                int strength = input.Select(x => (int) x).ToArray().Sum();
                strength = (int) Math.Floor(strength / 3.0);
                int timeToDefeat = strength * input.Length;

                if (!viruses.Contains(input))
                {
                    viruses.Add(input);
                }
                else
                {
                    timeToDefeat = (int) Math.Floor(timeToDefeat / 3.0);
                }

                health -= timeToDefeat;
                
                Console.WriteLine("Virus {0}: {1} => {2} seconds", input, strength, timeToDefeat);

                if (health <= 0) 
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                Console.WriteLine("{0} defeated in {1}m {2}s.", input, timeToDefeat / 60, timeToDefeat % 60);
                Console.WriteLine("Remaining health: {0}", health); 

                health = (int) Math.Floor(health * 1.2);

                if (health > initialHealth)
                {
                    health = initialHealth;
                } 
  
                input = Console.ReadLine();
            } 
            
            Console.WriteLine("Final Health: {0}", health);    
        }
    }
} 