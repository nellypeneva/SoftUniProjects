using System; 
namespace _10a_StudentGroups
{
    public class Student
    {
        public Student(string name, string email, DateTime regDate)
        {
            this.Name = name;
            this.Email = email;
            this.RegDate = regDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
    }
}
