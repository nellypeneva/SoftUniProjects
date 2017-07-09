using System.Collections.Generic;

namespace _09_TeamworkProjects
{
    public class Team
    {
        public Team (string teamName, string creatorName)
        {
            this.TeamName = teamName;
            this.CreatorName = creatorName;
            this.Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; } 
    }
}
