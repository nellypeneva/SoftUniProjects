using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text.RegularExpressions; 

namespace _03_NetherRealms
{
    public class NetherRealms
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x.Trim())
                                    .OrderBy(x => x)
                                    .ToArray();

            List<Demon> results = new List<Demon>();

            foreach (string name in input)
            {
                results.Add(new Demon(name));
            }

            //results = results.OrderBy(x => x.Name).ToList();

            foreach (var demon in results)
            {
                Console.WriteLine("{0} - {1} health, {2:f2} damage", demon.Name, demon.Health, demon.Damage);
            }
        } 
    }

    public class Demon
    {
        public Demon (string name)
        {
            this.Name = name;
            this.Health = CalculateHealth();
            this.Damage = CalculateDamage();
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public int CalculateHealth()
        {
            string patternHealth = @"([^\d\+\-\*/\.]+)";
            Regex regHealth = new Regex(patternHealth);
            MatchCollection matchesHealth = regHealth.Matches(this.Name);
            int health = 0;

            foreach (Match m in matchesHealth)
            {
                health += sumCodes(m.Groups[1].Value);
            }
            return health;
        }

        public double CalculateDamage()
        {
            string patternDamage = @"([+|-]?\d{1,}\.\d{1,}|[+|-]?\d+)";
            string patternOperations = @"([*]+)|([/]+)";
            Regex regDamage = new Regex(patternDamage);
            Regex regOperations = new Regex(patternOperations);

            MatchCollection matchesDamage = regDamage.Matches(this.Name);
            double damage = 0.0;

            foreach (Match m in matchesDamage)
            {
                damage += double.Parse(m.Groups[1].Value);
            }

            MatchCollection matchesOperations = regOperations.Matches(this.Name);
            int multNum = 0;
            int divNum = 0;

            foreach (Match m in matchesOperations)
            {
                multNum += m.Groups[1].Length;
                divNum += m.Groups[2].Length;
            }

            if (multNum > 0)
            {
                damage = damage * Math.Pow(2, multNum);
            }

            if (divNum > 0)
            {
                damage = damage / Math.Pow(2, divNum);
            }
            return damage;
        }

        public static int sumCodes(string text)
        {
            int result = text.Select(x => (int)x).Sum();
            return result;
        }
    }
}  