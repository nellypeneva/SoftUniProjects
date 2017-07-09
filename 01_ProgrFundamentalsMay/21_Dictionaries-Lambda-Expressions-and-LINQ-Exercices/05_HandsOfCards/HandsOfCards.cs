using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            Dictionary<string, int> cardPowers = new Dictionary<string, int> 
                { 
                    {"2",2}, 
                    {"3",3}, 
                    {"4",4}, 
                    {"5",5}, 
                    {"6",6}, 
                    {"7",7}, 
                    {"8",8}, 
                    {"9",9},   
                    {"10",10}, 
                    {"J",11}, 
                    {"Q",12}, 
                    {"K",13}, 
                    {"A",14}
                };

            Dictionary<string, int> typePowers = new Dictionary<string, int> 
                {
                    {"S",4}, 
                    {"H",3}, 
                    {"D",2}, 
                    {"C",1}
                };

            Dictionary<string, long> playerResults = new Dictionary<string, long>();

            Dictionary<string, List<string>> playerCards = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input!="JOKER")
            { 
                char[] separators = { ',', ' ' };
                string[] parameters = input.Split(':');
                string name=parameters[0];
                string[] cards = parameters[1].Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries); 

                if (!playerResults.ContainsKey(name))
                {
                    playerResults[name]=0; 
                }

                if (!playerCards.ContainsKey(name))
                {
                    playerCards[name] = new List<string>();
                }

                long result = 0;

                foreach (var card in cards)
                {
                    if (!playerCards[name].Contains(card))
                    {
                        playerCards[name].Add(card);
                        string currentCard = card.Substring(0, card.Length-1);
                        string currentType = card[card.Length - 1].ToString();
                        result += cardPowers[currentCard] * typePowers[currentType];
                    }
                }

                playerResults[name] += result; 

                input = Console.ReadLine();  
            } 

            foreach (var item in playerResults)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }            
        }
    }
}