using System.Collections.Generic; 

namespace _10a_StudentGroups
{
    public class Group
    {
        public Group(Town town) 
        {
            this.Town = town;
            this.Students = new List<Student>();
        }

        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
