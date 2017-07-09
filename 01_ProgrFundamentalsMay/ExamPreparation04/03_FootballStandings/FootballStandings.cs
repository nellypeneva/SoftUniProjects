using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions; 

namespace _03_FootballStandings
{
    class FootballStandings
    {
        static void Main()
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);

            string patternTeams = String.Format(@".*?{0}(.*?){0}.*?{0}(.*?){0}.*?(\d+):(\d+)", key); 

            Dictionary<string, TeamResults> results = new Dictionary<string, TeamResults>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                } 

                Match matchTeams = Regex.Match(input, patternTeams);

                if (matchTeams.Success)
                {
                    string team1 = matchTeams.Groups[1].Value.ToUpper();
                    team1 = Reverse(team1);

                    string team2 = matchTeams.Groups[2].Value.ToUpper();
                    team2 = Reverse(team2);

                    int score1 = int.Parse(matchTeams.Groups[3].Value);
                    int score2 = int.Parse(matchTeams.Groups[4].Value); 
                    int points1 = 0;
                    int points2 = 0;

                    if (score1 == score2)
                    {
                        points1 = 1;
                        points2 = 1;
                    }
                    else if (score1 > score2)
                    {
                        points1 = 3;
                    }
                    else
                    {
                        points2 = 3;
                    }

                    if (!results.ContainsKey(team1))
                    {
                        results[team1] = new TeamResults();
                    }

                    results[team1].Points += points1;
                    results[team1].Goals += score1;

                    if (!results.ContainsKey(team2))
                    {
                        results[team2] = new TeamResults();
                    }

                    results[team2].Points += points2;
                    results[team2].Goals += score2;
                }
            }

            var pointsResults = results.OrderByDescending(r => r.Value.Points).ThenBy(r => r.Key);

            Console.WriteLine("League standings:");
            int i = 0;

            foreach (var item in pointsResults)
            {
                i++;
                Console.WriteLine("{0}. {1} {2}",i, item.Key, item.Value.Points);
            }

            var scoreResults = results.OrderByDescending(r => r.Value.Goals).ThenBy(r => r.Key).Take(3);

            Console.WriteLine("Top 3 scored goals:");

            foreach (var item in scoreResults)
            {
                Console.WriteLine("- {0} -> {1}", item.Key, item.Value.Goals);
            }
    
        } 

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    public class TeamResults
    {
        public TeamResults() 
        {
            this.Goals = 0;
            this.Points = 0;
        }

        public int Goals { get; set; }
        public int Points { get; set; } 
    }
}

