using System.Collections.Generic; 

namespace _10a_StudentGroups
{
    public class Town
    {
        public Town(string name, int numSeats)
        {
            this.Name = name;
            this.NumSeats = numSeats;  
            this.Students = new List<Student>();
        }

        public string Name { get; set; }
        public int NumSeats { get; set; } 
        public List<Student> Students { get; set; }
    }
}
