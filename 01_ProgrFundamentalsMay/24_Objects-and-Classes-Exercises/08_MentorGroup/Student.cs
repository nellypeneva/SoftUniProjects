using System;
using System.Collections.Generic;

namespace _08_MentorGroup
{
    class Student
    {
        public Student(string name)
        {
            this.Name = name;
            this.Dates = new List<DateTime>();
            this.Comments = new List<string>(); 
        }

        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; } 
    }
}
