using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>(); 

            createTeams(count, teams);
            readMembers(teams);
            displaySortedTeams(teams);
            displaySortedBannedTeams(teams);            
        }

        public static void createTeams(int count, List<Team> teams)
        {
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creatorName = input[0];
                string teamName = input[1];

                int index1 = teams.FindIndex(item => item.TeamName == teamName);

                if (index1>=0)
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                    continue;
                }

                int index2 = teams.FindIndex(item => item.CreatorName == creatorName);
                 
                if (index2 >=0)
                {
                    Console.WriteLine("{0} cannot create another team!", creatorName);
                    continue;
                }

                teams.Add(new Team(teamName, creatorName));
                Console.WriteLine("Team {0} has been created by {1}!", teamName, creatorName);
            } 

        }

        public static void readMembers(List<Team> teams)
        {
            while (true)
            {
               string line = Console.ReadLine();

               if (line == "end of assignment")
               {
                   break;
               }

               string[] input = line.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
               string user = input[0];
               string teamName = input[1]; 

               int index1 = teams.FindIndex(item => item.TeamName == teamName);
        
               if (index1 < 0)
               {
                   Console.WriteLine("Team {0} does not exist!", teamName);
                   continue;
               }
            
               int index2 = teams.FindIndex(item => (item.Members.Contains(user) || item.CreatorName == user));

               if (index2 >= 0)
               {
                   Console.WriteLine("Member {0} cannot join team {1}!", user, teamName);
                   continue;
               }

               teams[index1].Members.Add(user);
            }
        }

        public static void displaySortedTeams(List<Team> teams)
        {
            var displayTeams = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName);

            foreach (var team in displayTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- {0}", team.CreatorName);

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    Console.WriteLine("-- {0}", member);
                }
            }
        }

         public static void displaySortedBannedTeams(List<Team> teams)
         {
                var bannedTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName);
 
                Console.WriteLine("Teams to disband:");

                foreach (var team in bannedTeams)
                {
                    Console.WriteLine(team.TeamName);
                } 
         }

    }
} 
 